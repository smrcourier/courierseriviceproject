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
    /// Interaction logic for Admin_2.xaml
    /// </summary>
    public partial class Admin_2 : Window
    {
        public Admin_2()
        {
            InitializeComponent();
        }

        private void Click_for_A3(object sender, RoutedEventArgs e)
        {
            Admin_3 wn2 = new Admin_3();
            wn2.Show();
            this.Close();
        }

        private void Click_for_A4(object sender, RoutedEventArgs e)
        {
            Admin_4 wn2 = new Admin_4();
            wn2.Show();
            this.Close();
        }

        private void Click_for_A9(object sender, RoutedEventArgs e)
        {
            Admin_9 wn2 = new Admin_9();
            wn2.Show();
            this.Close();
        }

        private void Click_for_A11(object sender, RoutedEventArgs e)
        {
            Admin_11 wn2 = new Admin_11();
            wn2.Show();
            this.Close();
        }

        private void Click_for_A13(object sender, RoutedEventArgs e)
        {
            Admin_13 wn2 = new Admin_13();
            wn2.Show();
            this.Close();
        }

        private void Click_for_A1(object sender, RoutedEventArgs e)
        {
            Admin_1 wn2 = new Admin_1();
            wn2.Show();
            this.Close();
        }
    }
}
