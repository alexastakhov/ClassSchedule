namespace Kabab.ClassSchedule.DeviceControl
{
    /// <summary>
    /// USB device descriptor.
    /// </summary>
    public class USBDeviceInfo
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="portName"></param>
        /// <param name="deviceID"></param>
        /// <param name="pnpDeviceID"></param>
        /// <param name="description"></param>
        public USBDeviceInfo(string name, string portName, string deviceID, string pnpDeviceID, string description)
        {
            this.Name = name;
            this.PortName = portName;
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }

        /// <summary>
        /// Device name, as system device name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// COM port name.
        /// </summary>
        public string PortName { get; private set; }

        /// <summary>
        /// Device identity.
        /// </summary>
        public string DeviceID { get; private set; }

        /// <summary>
        /// PnP device identity.
        /// </summary>
        public string PnpDeviceID { get; private set; }

        /// <summary>
        /// Device description.
        /// </summary>
        public string Description { get; private set; }
    }
}
