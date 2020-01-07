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
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
            this.DeviceList = new ObservableCollection<string>();

            this.UpdateDeviceList();
        }

        public ObservableCollection<string> DeviceList { get; private set; }

        private void DeviceRefreshButton_Click(object sender, RoutedEventArgs e)
        {
            this.UpdateDeviceList();
        }

        private void UpdateDeviceList()
        {
            var devices = UsbDeviceFinder.GetDeviceList();
        }
    }
}
