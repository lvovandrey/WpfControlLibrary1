using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfControlLibrary1
{
    public class VM: DependencyObject
    {

        public double Freq
        {
            get
            {
                return (double)GetValue(FreqProperty);
            }
            set
            {
                SetValue(FreqProperty, value);
            }
        }

        public static readonly DependencyProperty FreqProperty =
            DependencyProperty.Register("Freq",
                typeof(double), typeof(UserControl1));
    }
}
