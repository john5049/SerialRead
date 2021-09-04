using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace SerialRead
{
    public class viewModel : INotifyPropertyChanged
    {
        private double measurement;
        public double Measurement
        {
            set { measurement = value; OnPropertyChanged(nameof(Measurement));
            }
            get { return measurement; }
        }
      
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int angle;
        public int Angle
        {
            set { angle = value; OnPropertyChanged(nameof(Angle)); }
            get { return angle; }
        }
    }
}
