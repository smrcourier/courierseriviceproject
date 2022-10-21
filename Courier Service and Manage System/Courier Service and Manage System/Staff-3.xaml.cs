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
    /// Interaction logic for Staff_3.xaml
    /// </summary>
    public partial class Staff_3 : Window
    {
        public Staff_3()
        {
            InitializeComponent();
        }

        private void Click_for_S2(object sender, RoutedEventArgs e)
        {
            Staff_2 wn2 = new Staff_2();
            wn2.Show();
            this.Close();
        }

        private void click_for_s4(object sender, RoutedEventArgs e)
        {
            staff_4 wn2 = new staff_4();
            wn2.Show();
            this.Close();
        }

        private void click_for_s5(object sender, RoutedEventArgs e)
        {
            staff_5 wn2 = new staff_5();
            wn2.Show();
            this.Close();
        }

        private void click_for_s6(object sender, RoutedEventArgs e)
        {
            staff_6 wn2 = new staff_6();
            wn2.Show();
            this.Close();
        }
    }
}
