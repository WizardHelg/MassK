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
    class UsbDisk
    {
      //  public static List<string> GetUSBS(get;set;)
        
        public static string FindUsbPath()
        {
            foreach(string root in GetDiskList())
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
            throw new BException("USB с файлом \"scales.prj\" не найден");
        }

        public static List<string> GetDiskList()
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
