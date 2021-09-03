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

namespace WpfControlLibrary1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            DataContext = new VM();
            Freq2 = 123;
        }

        public double Freq2
        {
            get
            {
                return (double)GetValue(Freq2Property);
            }
            set
            {
                SetValue(Freq2Property, value);
            }
        }

        public static readonly DependencyProperty Freq2Property =
            DependencyProperty.Register("Freq2",
                typeof(double), typeof(UserControl1));


    }
}
