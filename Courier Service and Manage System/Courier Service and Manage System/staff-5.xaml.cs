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
    /// Interaction logic for staff_5.xaml
    /// </summary>
    public partial class staff_5 : Window
    {
        public staff_5()
        {
            InitializeComponent();
        }
        private void click_for_s3(object sender, RoutedEventArgs e)
        {
            Staff_3 wn2 = new Staff_3();
            wn2.Show();
            this.Close();
        }
    }
}
