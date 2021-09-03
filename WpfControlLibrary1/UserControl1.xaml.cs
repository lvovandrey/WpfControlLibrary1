using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    public delegate void PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e);
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl, INotifyPropertyChanged
    {
        public UserControl1()
        {
            InitializeComponent();
            DataContext = this;
            Freq2 = 123;
            OnFreq2Changed += UserControl1_OnFreq2Changed;
        }

        private void UserControl1_OnFreq2Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            VM.OnChanged();
        }



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

        public double Freq2
        {
            get
            {
                SetValue(Freq2Property, Freq * 2);
                return (double)GetValue(Freq2Property);
            }
            set
            {
                Freq = value / 2;
                SetValue(Freq2Property, value);
            }
        }

        public static readonly DependencyProperty Freq2Property =
            DependencyProperty.Register("Freq2",
                typeof(double), typeof(UserControl1),
                 new FrameworkPropertyMetadata(new PropertyChangedCallback(Freq2PropertyChangedCallback)));

        private static void Freq2PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (((UserControl1)d).OnFreq2Changed != null)
                ((UserControl1)d).OnFreq2Changed(d, e);
        }
        public event PropertyChanged OnFreq2Changed;



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));

        }
    }
