using System;
using System.Management;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;

namespace Kabab.ClassSchedule.DeviceControl
{
    public static class UsbDeviceFinder
    {
        public static List<USBDeviceInfo> GetDeviceList()
        {
            var result = new List<USBDeviceInfo>();
            var deviceList = new List<ManagementBaseObject>();
            ManagementObjectCollection collection;

            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_PnpEntity"))
                collection = searcher.Get();

            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine(s);
            }

            foreach (var device in collection)
            {
                Console.WriteLine("===================================");

                foreach (var prop in device.Properties)
                {
                    Console.WriteLine("\t{0} : {1}", prop.Name, prop.Value);
                    Console.WriteLine("===================================");

                    ////if (prop.Name == "Name")
                }

                deviceList.Add(device);
            }

            collection.Dispose();

            Console.Read();

            return result;
        }
    }
}