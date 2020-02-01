using Kabab.ClassSchedule.DeviceControl;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Kabab.ClassSchedule.Gui
{
    public class DeviceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "NULL";
            }

            var inValue = value as USBDeviceInfo;

            if (inValue == null)
            {
                return value;
            }

            return string.Format("{0} - {1}", inValue.PortName, inValue.Description);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
