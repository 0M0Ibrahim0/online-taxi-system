using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication6.Properties;
using System.Data.SqlClient;
namespace WindowsFormsApplication6
    
{
    
    public partial class first_page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
        public static string x = "", yp = "",ya="",yd="", z = "";
        public first_page()
        {
           
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.download__3_;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void first_page_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) textBox2.UseSystemPasswordChar = true;
            else textBox2.UseSystemPasswordChar = false;
        }

        //button login for admin
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            SqlCommand sda = new SqlCommand("SELECT COUNT(*) FROM Administrator WHERE email='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", con);
            con.Open();
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            int x = (int)sda.ExecuteScalar();
            if (x == 1)
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                first_page.x = "";
                first_page.x = "admin";
                first_page.ya = textBox1.Text;

                admin ins = new admin();
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Invalid email or password");
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            first_page.x = "";
            first_page.x = "sign";
            data d = new data();
            d.MdiParent = this.MdiParent;
            this.Hide();
            d.ShowDialog();
            this.Close();
        }

        // button login for passenger 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "") MessageBox.Show("Invalid email or password");
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
                con.Open();
                SqlCommand sda = new SqlCommand("SELECT COUNT(*) FROM Passenger WHERE email='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", con);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                int x = (int)sda.ExecuteScalar();
                if (x == 1)
                {
                    first_page.x = "";
                    first_page.x = "pass";
                    first_page.yp = textBox1.Text;
                    /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                    passenger p = new passenger();
                    p.MdiParent = this.MdiParent;
                    this.Hide();
                    p.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid email or password");


            }
        }

        //login for Driver
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            con.Open();
            SqlCommand sda = new SqlCommand("SELECT COUNT(*) FROM Driver WHERE email='" + textBox1.Text + "' AND dr_password='" + textBox2.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            int x = (int)sda.ExecuteScalar();
            if (x == 1)
            {
                first_page.x = "";
                first_page.x = "driver";
                first_page.yd = textBox1.Text;

                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */

                driver p = new driver();
                p.MdiParent = this.MdiParent;
                this.Hide();
                p.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Invalid email or password");

            
        }
    }
}
