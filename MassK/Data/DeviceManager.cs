using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace MassK.Data
{
   public class DeviceManager
    {
        ManagementObjectCollection collection;
        public void FindDevices()
        {

            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
            {
                collection = searcher.Get();
                foreach (var device in collection)
                {
                    var deviceId = (string) device.GetPropertyValue("DeviceID");
                    var pnpDeviceId = (string) device.GetPropertyValue("PNPDeviceID");
                    var descr = (string) device.GetPropertyValue("Description");
                    var classCode = device.GetPropertyValue("ClassCode"); //null here

                    Debug.WriteLine($"{deviceId}-{pnpDeviceId} {descr} {classCode}");
                }
            }
        }
    }
}
