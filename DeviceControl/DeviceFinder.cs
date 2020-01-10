using System;
using System.Management;
using System.Collections.Generic;
using System.IO.Ports;

namespace Kabab.ClassSchedule.DeviceControl
{
    public static class DeviceFinder
    {
        public static List<USBDeviceInfo> GetDeviceList()
        {
            var result = new List<USBDeviceInfo>();
            var usbDeviceList = new List<ManagementBaseObject>();
            ManagementObjectCollection collection;
            var comPortNames = SerialPort.GetPortNames();

            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_PnpEntity"))
            {
                collection = searcher.Get();
            }
                
            foreach (var device in collection)
            {
                Console.WriteLine("===================================");

                foreach (var prop in device.Properties)
                {
                    Console.WriteLine("\t{0} : {1}", prop.Name, prop.Value);

                    if (prop.Name == "Name")
                    {
                        foreach (var portName in comPortNames)
                        {
                            var value = prop.Value.ToString();

                            if (value.Contains(string.Format("({0})", portName)))
                            {
                                result.Add(
                                    new USBDeviceInfo(
                                        value,
                                        portName,
                                        (string)device.Properties["DeviceID"].Value,
                                        (string)device.Properties["PNPDeviceID"].Value,
                                        (string)device.Properties["Description"].Value));
                            }
                        }
                    }
                }

                usbDeviceList.Add(device);
            }

            collection.Dispose();

            return result;
        }
    }
}