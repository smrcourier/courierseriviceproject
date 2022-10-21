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
using MySql.Data.MySqlClient;
using System.Data;
namespace Courier_Service_and_Manage_System
{
    /// <summary>
    /// Interaction logic for Admin_8.xaml
    /// </summary>
    public partial class Admin_8 : Window
    {
        public Admin_8()
        {
            InitializeComponent();
        }

        private void Click_A7(object sender, RoutedEventArgs e)
        {
            Admin_4 wn2 = new Admin_4();
            wn2.Show();
            this.Close();
        }

        private void Check_Staff_List_click(object sender, RoutedEventArgs e)
        {
            string mycon = "server=localhost;user id=root;database=courierservicemanagement";
            string query = "select * from admin_add_staff_main";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader1 = null;

            con.Open();
            reader1 = com.ExecuteReader();

            staff_add_list_textblock.Text = "First Name\t Last Name\t Email\t Password\t Branch\t\n\n";

            while (reader1.Read())
            {



                staff_add_list_textblock.Text += reader1[0] + "\t";
                staff_add_list_textblock.Text += reader1[1] + "\t";
                staff_add_list_textblock.Text += reader1[2] + "\t";
                staff_add_list_textblock.Text += reader1[3] + "\t";
                staff_add_list_textblock.Text += reader1[4] + "\t";
                
            }
            con.Close();
        }
    }
}
