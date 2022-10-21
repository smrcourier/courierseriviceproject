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
    /// Interaction logic for Admin_12.xaml
    /// </summary>
    public partial class Admin_12 : Window
    {
        public Admin_12()
        {
            InitializeComponent();
        }

        private void Click_for_A11(object sender, RoutedEventArgs e)
        {
            Admin_11 wn2 = new Admin_11();
            wn2.Show();
            this.Close();
        }
    }
}
