using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Windows.Forms;


namespace MassK.Data
{
    class USBConnectionsChecker
    {
        private int devicesCount;
        private Timer updatingInformationTimer;

        public event EventHandler DeviceConnected;
        public event EventHandler DeviceDisconnected;


        private int GetDevicesCount()
        {
            return ((new ManagementObjectSearcher(@"select * from Win32_DiskDrive")).Get()).Count;
        }

        private void UpdatingInformationTimer_Tick(object sender, EventArgs e)
        {
            int newDevicesCountValue = GetDevicesCount();

            if (newDevicesCountValue != devicesCount)
            {
                if (newDevicesCountValue > devicesCount)
                {
                    devicesCount = newDevicesCountValue;
                    DeviceConnected(this, null);
                }
                else
                {
                    devicesCount = newDevicesCountValue;
                    DeviceDisconnected(this, null);
                }
            }
        }

        public USBConnectionsChecker()
        {
            devicesCount = GetDevicesCount();
            updatingInformationTimer = new Timer();
            updatingInformationTimer.Tick += new EventHandler(this.UpdatingInformationTimer_Tick);
            updatingInformationTimer.Interval = 1000;
            updatingInformationTimer.Enabled = true;
        }
    }
}
