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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Courier_Service_and_Manage_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_For_A1(object sender, RoutedEventArgs e)
        {
           Admin_1 wn2 = new Admin_1();
            wn2.Show();
            this.Close();
        }

        private void Click_for_S1(object sender, RoutedEventArgs e)
        {
            Staff_1 wn2 = new Staff_1();
            wn2.Show();
            this.Close();
        }

        private void Click_for_U1(object sender, RoutedEventArgs e)
        {
            User_1 wn2 = new User_1();
            wn2.Show();
            this.Close();
        }
    }
}
