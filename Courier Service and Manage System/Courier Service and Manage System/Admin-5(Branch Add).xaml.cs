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
    /// Interaction logic for Admin_5_Branch_Add_.xaml
    /// </summary>
    public partial class Admin_5_Branch_Add_ : Window
    {
        public Admin_5_Branch_Add_()
        {
            InitializeComponent();
        }

        private void Click_For_A4(object sender, RoutedEventArgs e)
        {
            Admin_4 wn2 = new Admin_4();
            wn2.Show();
            this.Close();
        }

        private void Click_A7(object sender, RoutedEventArgs e)
        {

            string str, city, state, country, postal_code, contact;

            str = textBox1.Text;
            city = textBox2.Text;
            state = textBox2.Text;
            country = textBox4.Text;
            postal_code = textBox5.Text;
            contact = textBox.Text;
            string mycon = "server=localhost;user id=root;database=courierservicemanagement;allowuservariables=True";
            string query = "insert into admin_add_staff (street, city, state, country, postal_code, contact) values('" + str + "', '" + city + "', '" + state + "', '" + country + "', '" + postal_code + "', '" + contact + "')";
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
