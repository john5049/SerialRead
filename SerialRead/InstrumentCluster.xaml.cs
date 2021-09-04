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

namespace SerialRead
{
    /// <summary>
    /// Interaction logic for InstrumentCluster.xaml
    /// </summary>
    public partial class InstrumentCluster : UserControl
    {
        public InstrumentCluster()
        {
            InitializeComponent();
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            ShaftSpeedTextBox.FontFamily = new FontFamily("Times New Roman");
            PressureTextBox.FontFamily = new FontFamily("Times New Roman");
            TemperatureTextBox.FontFamily = new FontFamily("Times New Roman");
        }
    }
}
