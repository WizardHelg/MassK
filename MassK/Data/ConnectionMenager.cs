using MassK.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.Data
{
    static class ConnectionMenager
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

        


    }
}
