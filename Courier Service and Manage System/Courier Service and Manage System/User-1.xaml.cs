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
    /// Interaction logic for User_1.xaml
    /// </summary>
    public partial class User_1 : Window
    {
        public User_1()
        {
            InitializeComponent();
        }

        private void Click_for_MW_from_U1(object sender, RoutedEventArgs e)
        {
            MainWindow wn2 = new MainWindow();
            wn2.Show();
            this.Close();
        }
    }
}
