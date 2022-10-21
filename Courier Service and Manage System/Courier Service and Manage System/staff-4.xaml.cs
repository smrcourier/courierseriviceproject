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
    /// Interaction logic for staff_4.xaml
    /// </summary>
    public partial class staff_4 : Window
    {
        public staff_4()
        {
            InitializeComponent();
        }

        private void click_for_s3(object sender, RoutedEventArgs e)
        {
            Staff_3 wn2 = new Staff_3();
            wn2.Show();
            this.Close();
        }

        private void click_for_staff_add(object sender, RoutedEventArgs e)
        {
            string fname, lname, branch_name, email_percel_holder, percel_type,weight_percel, refno;


            fname = first_name1.Text;
            lname = last_name.Text;
            branch_name = branch_textbox.Items[branch_textbox.SelectedIndex].ToString();
            email_percel_holder = email_add_percel.Text;
            percel_type = listbox_percel_type.Text;
           
            weight_percel = weight_textbox.Text;
            refno = ref_no_percel.Text;


            string mycon = "server=localhost;user id=root;database=courierservicemanagement;allowuservariables=True";
            string query = "insert into staff_add_percel (fname, sname, branchname, email, parcel_type, weight,ref_no) values('" + fname + "', '" + lname + "', '" + branch_name + "', '" + email_percel_holder + "', '" + percel_type + "', '" + weight_percel + "', '" + refno + "')";
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
