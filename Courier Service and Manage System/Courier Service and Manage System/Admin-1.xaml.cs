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
    /// Interaction logic for Admin_1.xaml
    /// </summary>
    public partial class Admin_1 : Window
    {
        public Admin_1()
        {
            InitializeComponent();
        }

        private void Click_for_A2(object sender, RoutedEventArgs e)
        {
            string password, userid;
            userid = user_id.Text;
            password = psw_user.Password;
            if (password == "123" && userid == "abc" || userid == "ABC" || userid == "Abc")
            {
                Admin_2 wn = new Admin_2();
                wn.Show();
                this.Close();
            }
            else
            {
                txb_msg.Text = "Wrong Password. Try Again!!";
            }
        }

        private void Click_for_MW(object sender, RoutedEventArgs e)
        {
            MainWindow wn2 = new MainWindow();
            wn2.Show();
            this.Close();
        }
    }
}
