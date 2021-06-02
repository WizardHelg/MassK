using MassK.BL;
using MassK.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MassK.Data
{
    static class ConnectionManager
    {
        public static class USB
        {
            public static string FindUsbPath()
            {
                foreach (string root in GetUsbList())
                    if (File.Exists(Path.Combine(root, "scales.prj")))
                        return root;

                return null;
            }

            private static List<string> GetUsbList()
            {
                List<string> buffer = new List<string>();
                foreach (DriveInfo info in DriveInfo.GetDrives())
                    if (info.DriveType == DriveType.Removable)
                        buffer.Add(info.Name);
                return buffer;
            }
        }

        public static class RAWFiles
        {
            public enum ScaleFileNum
            {
                PROD = 1,
                PLU = 5,
                KB = 64
            }

            public static string GetScaleFileName(ScaleFileNum num, string rootPath, bool foolName = false)
            {
                int last_version = -1;
                string file_prefix = $"{(int)num:D2}PC";
                foreach (var file in Directory.EnumerateFiles(rootPath, $"{file_prefix}*.dat", SearchOption.TopDirectoryOnly))
                {
                    string file_name = Path.GetFileNameWithoutExtension(file);
                    if (file_name.Length == 14 && int.TryParse(file_name.Substring(4), out int ver) && ver > last_version)
                        last_version = ver;
                }

                if (last_version < 0)
                    return null;

                return Path.Combine(foolName ? rootPath : "", $"{file_prefix}{last_version:D10}.dat");
            }

            public static string IncrementVersion(string fileName)
            {
                if (int.TryParse(Path.GetFileNameWithoutExtension(fileName).Substring(4), out int ver))
                    return $"{fileName.Substring(0, 4)}{++ver:D10}{Path.GetExtension(fileName)}";
                else
                    return null;
            }

            public static string GetDefaultFileName(ScaleFileNum num) => $"{(int)num:D2}PC{0:D10}.dat";
        }

        public static class Connection
        {
            public static List<ScaleInfo> Scan(List<ScaleInfo> data = null)
            {
                List<ScaleInfo> buffer = new List<ScaleInfo>();
                buffer.AddRange(NetScan());
                buffer.AddRange(ComScan());

                if (data == null)
                    data = buffer;
                else
                    foreach (var info in buffer)
                        if (data.Find(si => si.Connection == info.Connection) is ScaleInfo scale)
                            scale.Number = info.Number;
                        else
                            data.Add(info);

                return data;
            }

            private static List<ScaleInfo> NetScan()
            {
                const int numberPosition = 6;
                List<ScaleInfo> result = new List<ScaleInfo>();
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
                {
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontRoute, true);
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    socket.ReceiveTimeout = 1000;

                    byte[] buffer = new byte[socket.ReceiveBufferSize];
                    EndPoint point = new IPEndPoint(IPAddress.Any, 0);
                    int count = 0;

                    socket.SendTo(CMD.UDP_POLL, new IPEndPoint(IPAddress.Broadcast, 5001));

                    while(socket.IsBound)
                        try
                        {
                            count = socket.ReceiveFrom(buffer, ref point);
                            byte[] temp = buffer.Take(count).ToArray();
                            
                            if (CMD.GetData(temp) is byte[] data
                                && data[0] == 0x01
                                && BitConverter.ToUInt16(data, 1) == 0x0002)
                            {
                                IPEndPoint endPoint = point as IPEndPoint;
                                result.Add(new ScaleInfo()
                                {
                                    Number = BitConverter.ToInt32(data, numberPosition),
                                    Connection = $"{endPoint.Address}:{endPoint.Port}",
                                    State = true
                                });
                            }
                        }
                        catch
                        {
                            break;
                        }
                }

                return result;
            }



            private static List<ScaleInfo> ComScan()
            {
                //Добавить скан com портов
                return new List<ScaleInfo>();
            }

            public static void CheckState(List<ScaleInfo> data)
            {
                if ((data?.Count ?? 0) == 0)
                    return;

                var buffer = Scan();
                foreach (var scale in data)
                    if (buffer.Find(si => si.Connection == scale.Connection) is ScaleInfo info)
                    {
                        scale.State = true;
                        scale.Number = info.Number;
                    }
                    else
                        scale.State = false;
            }
        }

        private static class CMD
        {
            public static byte[] UDP_POLL => MakeCommand(new byte[] { 0x00 });

            private static byte[] MakeCommand(byte[] data)
            {
                List<byte> buffer = new List<byte>() { 0xf8, 0x55, 0xce };
                ushort len = (ushort)data.Length;
                ushort crc = CRC(data);

                buffer.AddRange(BitConverter.GetBytes(len));
                buffer.AddRange(data);
                buffer.AddRange(BitConverter.GetBytes(crc));

                return buffer.ToArray();
            }

            public static byte[] GetData(byte[] data)
            {
                if (data[0] != 0xf8 || data[1] != 0x55 || data[2] != 0xce)
                    return null;

                int len = BitConverter.ToUInt16(data, 3);
                if (data.Length != len + 7)
                    return null;

                byte[] result = data.Skip(5)
                                    .Take(len)
                                    .ToArray();

                if (BitConverter.ToUInt16(data, len + 5) != CRC(result))
                    return null;

                return result;
            }

            private static ushort CRC(byte[] data)
            {
                ushort crc = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    ushort accumulator = 0;
                    ushort temp = (ushort)((crc >> 8) << 8);

                    for(int bit = 0; bit < 8; bit++)
                    {
                        if (((temp ^ accumulator) & 0x8000) > 0)
                            accumulator = (ushort)((accumulator << 1) ^ 0x1021);
                        else
                            accumulator <<= 1;

                        temp <<= 1;
                    }

                    crc = (ushort)(accumulator ^ (crc << 8) ^ (data[i] & 0xff));
                }

                return crc;
            }
        }
    }
}
