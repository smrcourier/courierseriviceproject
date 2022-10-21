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
    /// Interaction logic for staff_7.xaml
    /// </summary>
    public partial class staff_7 : Window
    {
        public staff_7()
        {
            InitializeComponent();
        }

        private void click_for_s2(object sender, RoutedEventArgs e)
        {
            Staff_2 wn2 = new Staff_2();
            wn2.Show();
            this.Close();
        }
    }
}
