using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication6
{
    public partial class passenger_data : Form
    {
        public passenger_data()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            con.Open();
            SqlCommand command = (new SqlCommand("SELECT email FROM Passenger WHERE email=@mail", con));
            SqlParameter mail = new SqlParameter("@mail", first_page.yp);
            command.Parameters.Add(mail);
            string name = (string)command.ExecuteScalar();
            pass_email_txtbox.Text = name;

            SqlCommand command1 = (new SqlCommand("SELECT name FROM Passenger WHERE email=@mail1", con));
            SqlParameter mail1 = new SqlParameter("@mail1", first_page.yp);
            command1.Parameters.Add(mail1);
            string name1 = (string)command1.ExecuteScalar();
            pass_name_txtbox.Text = name1;

            SqlCommand command2 = (new SqlCommand("SELECT phone_number FROM Passenger WHERE email=@mail2", con));
            SqlParameter mail2 = new SqlParameter("@mail2", first_page.yp);
            command2.Parameters.Add(mail2);
            string name2 = (string)command2.ExecuteScalar();
            pass_phone_txtbox.Text = name2;


        }

        private void passenger_data_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            passenger p = new passenger();
            p.MdiParent = this.MdiParent;
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void pass_email_txtbox_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
