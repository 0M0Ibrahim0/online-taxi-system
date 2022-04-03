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
    public partial class driver_trip : Form
    {
        public driver_trip()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            con.Open();
            SqlCommand command = (new SqlCommand("SELECT pass_email FROM Trip inner join Driver on Trip.dr_id =Driver.id WHERE Driver.email=@mail", con));
            SqlParameter mail = new SqlParameter("@mail", first_page.yd);
            command.Parameters.Add(mail);
            string name = (string)command.ExecuteScalar();
            textBox2.Text = name;

            SqlCommand command1 = (new SqlCommand("SELECT name FROM Passenger WHERE email=@mail1", con));
            SqlParameter mail1 = new SqlParameter("@mail1", name);
            command1.Parameters.Add(mail1);
            string name1 = (string)command1.ExecuteScalar();
            textBox4.Text = name1;

            SqlCommand command2 = (new SqlCommand("SELECT phone_number FROM Passenger WHERE email=@mail1", con));
            SqlParameter mail2 = new SqlParameter("@mail1", name);
            command2.Parameters.Add(mail2);
            string name2 = (string)command2.ExecuteScalar();
           textBox3.Text = name2;

          SqlCommand command3 = (new SqlCommand("SELECT location FROM Passenger WHERE email=@mail1", con));
            SqlParameter mail3 = new SqlParameter("@mail1", name);
            command3.Parameters.Add(mail3);
            string name3 = (string)command3.ExecuteScalar();
            textBox1.Text = name3;
            con.Close();
        }

        private void driver_trip_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            finish_trip ft = new finish_trip();
            ft.MdiParent = this.MdiParent;
            ft.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driver p = new driver();
            p.MdiParent = this.MdiParent;
            this.Hide();
            p.ShowDialog();
            this.Close();
        }
    }
}
