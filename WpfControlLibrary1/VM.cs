using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfControlLibrary1
{
    public class VM: DependencyObject, INotyfyPropertyChanged
    {

        private double freq;
        public double Freq
        {
            get
            {
                return freq;// (double)GetValue(FreqProperty);
            }
            set
            {
                freq = value;// SetValue(FreqProperty, value);
                OnPropertyChanged("Freq");
            }
        }

        //public static readonly DependencyProperty FreqProperty =
        //    DependencyProperty.Register("Freq",
        //        typeof(double), typeof(UserControl1));


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void OnChanged()
        {
            OnPropertyChanged("Freq");
        }
    }
}
