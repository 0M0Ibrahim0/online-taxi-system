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
    public partial class finish_trip : Form
    {
        public finish_trip()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            con.Open();

            if (first_page.yd != "")
            {
                SqlCommand command = (new SqlCommand("SELECT time FROM Trip inner join Driver on Trip.dr_id =Driver.id WHERE Driver.email=@mail", con));
                SqlParameter mail = new SqlParameter("@mail", first_page.yd);
                command.Parameters.Add(mail);
                int name = (int)command.ExecuteScalar();
                textBox2.Text = name.ToString();

                SqlCommand command1 = (new SqlCommand("SELECT cost FROM Trip WHERE time=@mail1", con));
                SqlParameter mail1 = new SqlParameter("@mail1", name);
                command1.Parameters.Add(mail1);
                string name1 = (string)command1.ExecuteScalar();
                textBox3.Text = name1;

                SqlCommand command2 = (new SqlCommand("SELECT tr_id FROM Trip WHERE time=@mail1", con));
                SqlParameter mail2 = new SqlParameter("@mail1", name);
                command2.Parameters.Add(mail2);
                int name2 = (int)command2.ExecuteScalar();
                textBox4.Text = name2.ToString();
            }
            else if(first_page.yp!="")
            {
                SqlCommand command = (new SqlCommand("SELECT time FROM Trip WHERE pass_email = @mail", con));
                SqlParameter mail = new SqlParameter("@mail", first_page.yp);
                command.Parameters.Add(mail);
                int name = (int)command.ExecuteScalar();
                textBox2.Text = name.ToString();

                SqlCommand command1 = (new SqlCommand("SELECT cost FROM Trip WHERE time = @mail1", con));
                SqlParameter mail1 = new SqlParameter("@mail1", name);
                command1.Parameters.Add(mail1);
                string name1 = (string)command1.ExecuteScalar();
                textBox3.Text = name1;

                SqlCommand command2 = (new SqlCommand("SELECT tr_id FROM Trip WHERE time = @mail1", con));
                SqlParameter mail2 = new SqlParameter("@mail1", name);
                command2.Parameters.Add(mail2);
                int name2 = (int)command2.ExecuteScalar();
                textBox4.Text = name2.ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( first_page.yd == "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
                con.Open();
                string insertStr = @"update Trip set passenger_rating = '" + textBox1.Text + "'";
                SqlCommand cmd1 = new SqlCommand(insertStr, con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            else {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
                con.Open();
                string insertStr = @"update Trip set driver_rating = '" + textBox1.Text + "'";
                SqlCommand cmd1 = new SqlCommand(insertStr, con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Trip Finish");
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            complain f = new complain();
            f.ShowDialog();
            
        }

        private void finish_trip_Load(object sender, EventArgs e)
        {

        }
    }
}
