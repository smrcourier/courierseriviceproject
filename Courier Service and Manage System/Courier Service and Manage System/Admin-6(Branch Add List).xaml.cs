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
    /// Interaction logic for Admin_6.xaml
    /// </summary>
    public partial class Admin_6 : Window
    {
        public Admin_6()
        {
            InitializeComponent();
        }



        private void Click_For_A5(object sender, RoutedEventArgs e)
        {
            Admin_4 wn2 = new Admin_4();
            wn2.Show();
            this.Close();
        }


        private void Click_For_branch_add_list(object sender, RoutedEventArgs e)
        {
            string mycon = "server=localhost;user id=root;database=courierservicemanagement";
            string query = "select * from admin_add_staff";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader = null;

            con.Open();
            reader = com.ExecuteReader();

            branch_add_list_textblock.Text = "Street\t City\t State\t Country\t Postal Code\t Contact\n\n";

            while (reader.Read())
            {

                
         
                branch_add_list_textblock.Text +=  reader[0]+ "\t";
                branch_add_list_textblock.Text +=  reader[1]+ "\t"; 
                branch_add_list_textblock.Text +=  reader[2]+ "\t"; 
                branch_add_list_textblock.Text +=  reader[3]+ "\t"; 
                branch_add_list_textblock.Text +=  reader[4]+ "\t"; 
                branch_add_list_textblock.Text +=  reader[5]+ "\t\n"; 
            }
            con.Close();
        }
    }
}
