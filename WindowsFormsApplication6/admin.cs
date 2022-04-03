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
    public partial class admin : Form
    {
        public static string fun_type = "",email="";
        public static string combo = "";
        public admin()
        {
            InitializeComponent();
        }

        //add button 
        private void button3_Click(object sender, EventArgs e)
        {
            fun_type = "add";
            combo = comboBox1.Text;
            email = textBox1.Text;
            if (comboBox1.Text == "Passenger")
            {
                data d = new data();
                d.MdiParent = this.MdiParent;
                this.Hide();
                d.ShowDialog();
                this.Close();
            }
            else
            {
                add_driver d = new add_driver();
                this.Hide();
                d.ShowDialog();
                this.Close();
            }
        }

        // delete button
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            con.Open();

            if (comboBox1.Text == "Passenger")
            {
                SqlCommand cmd = new SqlCommand("select count (*)from Passenger where email ='" + textBox1.Text + "'", con);
                int c = (int)cmd.ExecuteScalar();

                if (c == 1)
                {
                    SqlCommand cd = new SqlCommand(@"delete from Passenger where email ='"+textBox1.Text+"'", con);                    
                    cd.ExecuteNonQuery();
                    MessageBox.Show("deleted");
                    con.Close();
                }
                else MessageBox.Show("Enter Right E-Mail");
            }

            else
            {
                SqlCommand cmd = new SqlCommand("select count (*)from Driver where email ='" + textBox1.Text + "'", con);
                int c = (int)cmd.ExecuteScalar();

                if (c == 1)
                {
                    SqlCommand cd = new SqlCommand(@"delete from Driver where email ='" + textBox1.Text + "'", con);
                    cd.ExecuteNonQuery();
                    MessageBox.Show("deleted");
                    con.Close();
                }
                else MessageBox.Show("Enter Right E-Mail");
            }
        }
        
        //update button
        private void button1_Click(object sender, EventArgs e)
        {
            
            fun_type = "update";
            combo = comboBox1.Text;
            email = textBox1.Text;
            data d = new data();

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            con.Open();

            if (comboBox1.Text == "Passenger")
            {
                SqlCommand cmd = new SqlCommand("select count (*)from Passenger where email ='" + textBox1.Text + "'", con);
                int c = (int)cmd.ExecuteScalar();

                if (c == 1)
                {
                   
                    d.MdiParent = this.MdiParent;
                    this.Hide();
                    d.ShowDialog();
                    this.Close();
                    con.Close();
                }
                else MessageBox.Show("Enter Right E-Mail For Passenger");
            }

            else if(comboBox1.Text == "Driver")
            {

                SqlCommand cmd = new SqlCommand("select count (*)from Driver where email ='" + textBox1.Text + "'", con);
                int c = (int)cmd.ExecuteScalar();

                if (c == 1)
                {
                    d.MdiParent = this.MdiParent;
                    this.Hide();
                    d.ShowDialog();
                    this.Close();
                    con.Close();
                    
                }
                else MessageBox.Show("Enter Right E-Mail");
            }
            MessageBox.Show("Choose Your Category First ");
        }


        //log out button
        private void button5_Click(object sender, EventArgs e)
        {
            first_page.yd = "";
            first_page.x = "";
            first_page f = new first_page();
            f.MdiParent = this.MdiParent;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        //add promo button
        private void button4_Click(object sender, EventArgs e)
        {
            promo pr = new promo();
            pr.MdiParent = this.MdiParent;
            this.Hide();
            pr.ShowDialog();
            this.Close();
        }
    }
}
