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
    public partial class complain : Form
    {
        public complain()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            con.Open();
            if (first_page.yd != "")
            {
                SqlCommand com = new SqlCommand("select tr_id from Trip inner join Driver on Trip.dr_id=Driver.id where Driver.email ='" + first_page.yd + "'", con);
                int s = (int)com.ExecuteScalar();
                textBox1.Text = s.ToString();
                
            }
            else if (first_page.yp!="")
            {
                SqlCommand com = new SqlCommand("select tr_id from Trip where pass_email ='" + first_page.yp + "'", con);
                int s = (int)com.ExecuteScalar();
                textBox1.Text = s.ToString();
                
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(first_page.yd!="")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
                con.Open();

                SqlCommand cmd = new SqlCommand("select count (*)from Trip where tr_id ='"+ textBox1.Text + "'", con);
                int c = (int)cmd.ExecuteScalar();
                if (c == 1)
                {
                    string insertStr = @"update Trip set driver_complaint = '" + richTextBox1.Text+"'";
                    SqlCommand cmd1 = new SqlCommand(insertStr, con);
                    cmd1.ExecuteNonQuery();

                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("insert into Trip(tr_id,driver_complaint) values('" + textBox1.Text+"','"+richTextBox1.Text+"')", con);
                    cmd2.ExecuteNonQuery();
                }
                con.Close();
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
                con.Open();

                SqlCommand cmd = new SqlCommand("select count (*)from Trip where tr_id ='" + textBox1.Text + "'", con);
                int c = (int)cmd.ExecuteScalar();
                if (c == 1)
                {
                    string insertStr = @"update Trip set passenger_complaint = '" + richTextBox1.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(insertStr, con);
                    cmd1.ExecuteNonQuery();

                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("insert into Trip(tr_id,passenger_complaint) values('" + textBox1.Text + "','" + richTextBox1.Text + "')", con);
                    cmd2.ExecuteNonQuery();
                }
                con.Close();
            }
            MessageBox.Show("Complaint Sent");
            this.Hide();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           }

        private void complain_Load(object sender, EventArgs e)
        {

        }
    }
}
