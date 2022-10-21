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
using System.Windows.Shapes;

namespace Courier_Service_and_Manage_System
{
    /// <summary>
    /// Interaction logic for Staff_2.xaml
    /// </summary>
    public partial class Staff_2 : Window
    {
        public Staff_2()
        {
            InitializeComponent();
        }

        private void click_for_S1(object sender, RoutedEventArgs e)
        {
            Staff_1 wn2 = new Staff_1();
            wn2.Show();
            this.Close();
        }

        private void Click_for_S3(object sender, RoutedEventArgs e)
        {
            Staff_3 wn2 = new Staff_3();
            wn2.Show();
            this.Close();
        }

        private void click_for_s7(object sender, RoutedEventArgs e)
        {
            staff_7 wn2 = new staff_7();
            wn2.Show();
            this.Close();
        }
    }
}
