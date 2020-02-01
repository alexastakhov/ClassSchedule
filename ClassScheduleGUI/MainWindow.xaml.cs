using Kabab.ClassSchedule.DeviceControl;
using System.Collections.ObjectModel;
using System.Windows;

namespace Kabab.ClassSchedule.Gui
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private USBDeviceInfo selectedDevice;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
            this.DeviceList = new ObservableCollection<USBDeviceInfo>();

            this.UpdateDeviceList();
        }

        public ObservableCollection<USBDeviceInfo> DeviceList { get; private set; }

        private void DeviceRefreshButton_Click(object sender, RoutedEventArgs e)
        {
            this.UpdateDeviceList();
        }

        private void UpdateDeviceList()
        {
            var devices = DeviceFinder.GetDeviceList();

            this.DeviceList.Clear();

            devices.ForEach(d => this.DeviceList.Add(d));
            this.deviceCombo.SelectedIndex = 0;

            if (this.DeviceList.Contains(this.selectedDevice))
            {
                this.deviceCombo.SelectedItem = this.selectedDevice;
            }
        }

        private void DeviceCombo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (this.deviceCombo.SelectedItem != null)
            {
                this.selectedDevice = (USBDeviceInfo)this.deviceCombo.SelectedItem;
            }
        }
    }
}
