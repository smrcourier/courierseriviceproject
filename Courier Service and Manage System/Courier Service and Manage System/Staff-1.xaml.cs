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
    /// Interaction logic for Staff_1.xaml
    /// </summary>
    public partial class Staff_1 : Window
    {
        public Staff_1()
        {
            InitializeComponent();
        }

        private void Click_for_S2(object sender, RoutedEventArgs e)
        {
            string password, userid;
            userid = user_id.Text;
            password = psw_user.Password;
            if (password == "123" && userid == "abc" || userid == "ABC" || userid == "Abc")
            {
                Staff_2 wn = new Staff_2();
                wn.Show();
                this.Close();
            }
            else
            {
                txb_msg.Text = "Wrong Password. Try Again!!";
            }
        }

        private void Click_for_MW_from_S1(object sender, RoutedEventArgs e)
        {
            MainWindow wn2 = new MainWindow();
            wn2.Show();
            this.Close();
        }
    }
}
