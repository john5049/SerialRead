using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.IO.Ports;

namespace SerialRead
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        viewModel vm = new viewModel();
        
        public MainWindow()
        {
            InitializeComponent();
            vm = (viewModel)FindResource("viewModel");
            this.DataContext = vm;
        }

        [STAThread]
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SerialPortProgram();
        }

        private void SerialPortProgram()
        {
            Console.WriteLine("Incoming Data:");

            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();
            Console.ReadLine();
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string temp = port.ReadLine();
            double conversion = 1023 / 210;
            //Console.WriteLine(temp);
            vm.Measurement = Convert.ToDouble(temp);
            vm.Angle = (int)Math.Round(vm.Measurement / conversion);
            Console.WriteLine(vm.Measurement);
            
        }
    }
}
