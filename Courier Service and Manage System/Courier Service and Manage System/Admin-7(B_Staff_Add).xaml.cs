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
    /// Interaction logic for Admin_7.xaml
    /// </summary>
    public partial class Admin_7 : Window
    {
        public Admin_7()
        {
            InitializeComponent();
        }

        private void Click_for_A4(object sender, RoutedEventArgs e)
        {
            Admin_4 wn2 = new Admin_4();
            wn2.Show();
            this.Close();
        }

        private void Click_for_A8(object sender, RoutedEventArgs e)
        {
            string first_name, l_name, email1, password, selectedItem_branch;

            first_name = f_name.Text;
            l_name = last_name.Text;
            email1 = email.Text;
            password = pass.Text.ToString();
            selectedItem_branch = branch_name.Items[branch_name.SelectedIndex].ToString();

            string mycon = "server=localhost;user id=root;database=courierservicemanagement;allowuservariables=True";
            string query = "insert into admin_add_staff_main (fname_staff, lname_staff, email_staff, password, branch) values('" + first_name + "', '" + l_name + "', '" + email1 + "', '" + password + "', '" + selectedItem_branch + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();
            con.Close();
            MessageBox.Show("Info. Inserted Successfully...");

            MessageBox.Show("Successfully Submitted");
        }
    }
}
