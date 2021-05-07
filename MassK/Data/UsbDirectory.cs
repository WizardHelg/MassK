﻿using MassK.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.Data
{
    class UsbDirectory
    {
        public static string FindUsbPath()
        {
            foreach(string root in GetUsbList())
            {
                Debug.WriteLine(root);
                foreach (string file in Directory.GetFiles(root)) 
                {
                    if (Path.GetFileName(file) == "scales.prj")
                    {

                    return root;
                    }
                }
            }
            throw new BException("USB с файлом \"scales.prj\"  не найден");
        }
        

        /// <summary>
        /// Получает список USB дисков
        /// </summary>
        /// <returns></returns>
        /// <remarks>Перенеси куда тебе будет удобно. Можно и просто удалить</remarks>
        public static List<string> GetUsbList()
        {
            {
                List<string> buffer = new List<string>();
                foreach (DriveInfo info in DriveInfo.GetDrives())
                    if (info.DriveType == DriveType.Removable)
                        buffer.Add(info.Name);
                return buffer.Count > 0 ? buffer : null;
            }
        }
    }
}