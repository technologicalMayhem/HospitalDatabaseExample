using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using HospitalDatabaseExample.Model;

namespace HospitalManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private double _percent = 0;
        private DispatcherTimer _timer;
        
        public MainWindow()
        {
            InitializeComponent();
            _percent = 1;
            LoadingBar.Width = 0;
            _timer = new DispatcherTimer();
            _timer.Tick += Update;
            _timer.Interval = TimeSpan.FromMilliseconds(5);
            _timer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            if (_percent < .3)
            {
                _percent += 0.001;
            }
            else if (_percent < .7)
            {
                _percent += 0.01;
            }
            else if (_percent < 1)
            {
                _percent += 0.02;
            }
            else
            {
                var registration = new PatientRegistration();
                Close();
                registration.Show();
                _timer.Stop();
            }
            LoadingBar.Width = ActualWidth * _percent;
        }
    }
}