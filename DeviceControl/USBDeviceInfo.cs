namespace Kabab.ClassSchedule.DeviceControl
{
    public class USBDeviceInfo
    {
        public USBDeviceInfo(string name, string portName, string deviceID, string pnpDeviceID, string description)
        {
            this.Name = name;
            this.PortName = portName;
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }

        public string Name { get; private set; }

        public string PortName { get; private set; }

        public string DeviceID { get; private set; }

        public string PnpDeviceID { get; private set; }

        public string Description { get; private set; }
    }
}
