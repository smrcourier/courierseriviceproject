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
    /// Interaction logic for Admin_4.xaml
    /// </summary>
    public partial class Admin_4 : Window
    {
        public Admin_4()
        {
            InitializeComponent();
        }

        private void Click_for_brach_add_A5(object sender, RoutedEventArgs e)
        {
            Admin_5_Branch_Add_ wn2 = new Admin_5_Branch_Add_();
            wn2.Show();
            this.Close();
        }

        private void Click_for_A6(object sender, RoutedEventArgs e)
        {
            Admin_6 wn2 = new Admin_6();
            wn2.Show();
            this.Close();
        }

        private void Click_Add_staff(object sender, RoutedEventArgs e)
        {
            Admin_7 wn2 = new Admin_7();
            wn2.Show();
            this.Close();
        }

        private void Click_Staff_List(object sender, RoutedEventArgs e)
        {
            Admin_8 wn2 = new Admin_8();
            wn2.Show();
            this.Close();
        }

        private void click_for_A3(object sender, RoutedEventArgs e)
        {
            Admin_2 wn2 = new Admin_2();
            wn2.Show();
            this.Close();
        }
    }
}
