﻿using MassK.BL;
using MassK.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static MassK.Data.ConnectionManager;

namespace MassK
{
    class ScaleCommandTest
    {

        public static byte[] UDP_POLL => MakeCommand(new byte[] { 0x00 });

        public static byte[] TCP_GET_STATUSES => MakeCommand(new byte[] { 0x80 });

        public static byte[] TCP_SET_WORK_MODE => MakeCommand(new byte[] { 0x91, 0x04 });

        public static byte[] TCP_REQ_UFILES_(byte fileNum, ushort part)
        {
            List<byte> buffer = new List<byte>();

            buffer.Add(0x58);
            buffer.Add(fileNum);
            buffer.AddRange(BitConverter.GetBytes((ushort)0));
            buffer.AddRange(BitConverter.GetBytes(part));

            return MakeCommand(buffer.ToArray());
        }
        public static byte[] TCP_REQ_UFILES(byte fileNum, ushort part)
        {
            List<byte> buffer = new List<byte>();

            buffer.Add(0x85);
            buffer.Add(fileNum);
            buffer.AddRange(BitConverter.GetBytes((ushort)0));
            buffer.AddRange(BitConverter.GetBytes(part));

            return MakeCommand(buffer.ToArray());
        }


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

                for (int bit = 0; bit < 8; bit++)
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

        //Загрузка файлов с весов
        //TODO протестировать загрузку файла
        /// <summary>
        /// Загружает продуктовый файл из весов
        /// </summary>
        /// <param name="scale">Данные подключения</param>
        /// <param name="savePath">путь куда запишется файл</param>
        /// <param name="fileNum">Номер файла. См приложение  4.1</param>
        public static void LoadFile(ScaleInfo scale, string savePath, RAWFiles.ScaleFileNum fileNum)
        {
            Socket socket = null;
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(scale);
                socket.Send(TCP_SET_WORK_MODE);

                byte[] buffer = new byte[1024];

                int bytes = socket.Receive(buffer, buffer.Length, SocketFlags.None);
                byte[] data = buffer.Take(bytes).ToArray();
                data = GetData(data);

                if (data[0] != 0x51)
                    throw new ApplicationException("Ошибка установки режима работы весов");

                using (FileStream fs = new FileStream(savePath, FileMode.Create))
                {
                    ushort cur_part = 1;
                    while (true)
                    {
                        socket.Send(TCP_REQ_UFILES((byte)fileNum, cur_part++));
                        bytes = socket.Receive(buffer, buffer.Length, SocketFlags.None);
                        data = buffer.Take(bytes).ToArray();
                        data = GetData(data);

                        if (data[0] != 0x45)
                            throw new ApplicationException("Ошибка при загрузке файла из чертовых весов");

                        ushort data_len = BitConverter.ToUInt16(data, 6);

                        fs.Write(data, 8, data_len);

                        if (BitConverter.ToUInt16(data, 2) == BitConverter.ToUInt16(data, 4))
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                socket?.Shutdown(SocketShutdown.Both);
                socket?.Close();
            }
        }

        internal static void GetInfo(ScaleInfo scale, string savePath, RAWFiles.ScaleFileNum fileNum)
        {
            Socket socket = null;
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(scale);
                 int res = socket.Send(UDP_POLL);
                 Debug.WriteLine(res.ToString());
                socket?.Shutdown(SocketShutdown.Both);
                socket?.Close();

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(scale);
                socket.Send(TCP_SET_WORK_MODE);

                byte[] buffer = new byte[1024];

                int bytes = socket.Receive(buffer, buffer.Length, SocketFlags.None);
                byte[] data = buffer.Take(bytes).ToArray();
                data = GetData(data);

                Debug.WriteLine(data.ToString());

                if (data[0] != 0x51)
                    throw new ApplicationException("Ошибка установки режима работы весов");

                socket?.Shutdown(SocketShutdown.Both);
                socket?.Close();

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(scale);               

                using (FileStream fs = new FileStream(savePath, FileMode.Create))
                {
                    ushort cur_part = 1;
                    while (true)
                    {
                        socket.Send(TCP_REQ_UFILES((byte)fileNum, cur_part++));
                        bytes = socket.Receive(buffer, buffer.Length, SocketFlags.None);
                        data = buffer.Take(bytes).ToArray();
                        data = GetData(data);

                       // byte[] dt = GetData(data);
                        //if (data[0] != 0x45)
                        //    throw new ApplicationException("Ошибка при загрузке файла из чертовых весов");

                        // ushort data_len = BitConverter.ToUInt16(data, 6);
                          ushort data_len = BitConverter.ToUInt16(data,6);
                        fs.Write(data, 8, data_len);

                        if (BitConverter.ToUInt16(data, 2) == BitConverter.ToUInt16(data, 4))
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                socket?.Shutdown(SocketShutdown.Both);
                socket?.Close();
            }
        }
    }
}