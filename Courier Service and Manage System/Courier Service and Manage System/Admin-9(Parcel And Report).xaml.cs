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
    /// Interaction logic for Admin_9.xaml
    /// </summary>
    public partial class Admin_9 : Window
    {
        public Admin_9()
        {
            InitializeComponent();
        }

        private void Click_for_A10(object sender, RoutedEventArgs e)
        {
            Admin_10 wn2 = new Admin_10();
            wn2.Show();
            this.Close();
        }

        private void Click_For_A2(object sender, RoutedEventArgs e)
        {
            Admin_2 wn2 = new Admin_2();
            wn2.Show();
            this.Close();
        }
    }
}
