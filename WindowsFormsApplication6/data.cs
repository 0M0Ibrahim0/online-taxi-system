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
    public partial class data : Form
    {

        public data()
        {

            InitializeComponent();

            SqlConnection con1 = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   

            //sign up
            if (first_page.ya == "" && first_page.yd == "" && first_page.yp == "")
            {
                pass_email_txtbox.Text = "";
                pass_name_txtbox.Text = "";
                pass_phone_txtbox.Text = "";
                pass_passward_txtbox.Text = "";

            }


            //data for passenger
            else if (first_page.ya == "" && first_page.yd == "")
            {
                con1.Open();
                SqlCommand command = (new SqlCommand("SELECT email FROM Passenger WHERE email=@mail", con1));
                SqlParameter mail = new SqlParameter("@mail", first_page.yp);
                command.Parameters.Add(mail);
                string name11 = (string)command.ExecuteScalar();
                pass_email_txtbox.Text = name11;
                pass_email_txtbox.ReadOnly = true;
                SqlCommand command1 = (new SqlCommand("SELECT name FROM Passenger WHERE email=@mail1", con1));
                SqlParameter mail1 = new SqlParameter("@mail1", first_page.yp);
                command1.Parameters.Add(mail1);
                string name12 = (string)command1.ExecuteScalar();
                pass_name_txtbox.Text = name12;

                SqlCommand command2 = (new SqlCommand("SELECT phone_number FROM Passenger WHERE email=@mail2", con1));
                SqlParameter mail2 = new SqlParameter("@mail2", first_page.yp);
                command2.Parameters.Add(mail2);
                string name13 = (string)command2.ExecuteScalar();
                pass_phone_txtbox.Text = name13;

                SqlCommand command3 = (new SqlCommand("SELECT password FROM Passenger WHERE email=@mail2", con1));
                SqlParameter mail3 = new SqlParameter("@mail2", first_page.yp);
                command3.Parameters.Add(mail3);
                string name14 = (string)command3.ExecuteScalar();
                pass_passward_txtbox.Text = name14;
                con1.Close();
            }
          
            //data for driver
            if (first_page.yd != "" && first_page.x == "driver")
            {
                con1.Open();
                SqlCommand command = (new SqlCommand("SELECT email FROM Driver WHERE email=@mail", con1));
                SqlParameter mail = new SqlParameter("@mail", admin.email);
                command.Parameters.Add(mail);
                string name11 = (string)command.ExecuteScalar();
                pass_email_txtbox.Text = name11;
                pass_email_txtbox.ReadOnly = true;
                SqlCommand command1 = (new SqlCommand("SELECT name FROM Driver WHERE email=@mail1", con1));
                SqlParameter mail1 = new SqlParameter("@mail1", admin.email);
                command1.Parameters.Add(mail1);
                string name12 = (string)command1.ExecuteScalar();
                pass_name_txtbox.Text = name12;

                SqlCommand command2 = (new SqlCommand("SELECT phone FROM Driver WHERE email=@mail2", con1));
                SqlParameter mail2 = new SqlParameter("@mail2", admin.email);
                command2.Parameters.Add(mail2);
                string name13 = (string)command2.ExecuteScalar();
                pass_phone_txtbox.Text = name13;

                SqlCommand command3 = (new SqlCommand("SELECT dr_password FROM Driver WHERE email=@mail2", con1));
                SqlParameter mail3 = new SqlParameter("@mail2", admin.email);
                command3.Parameters.Add(mail3);
                string name14 = (string)command3.ExecuteScalar();
                pass_passward_txtbox.Text = name14;
                con1.Close();
            }

            //data for driver to admin show it
            if (first_page.ya != "" && admin.fun_type=="update"&&admin.combo=="Driver")
            {
                con1.Open();
                SqlCommand command = (new SqlCommand("SELECT email FROM Driver WHERE email=@mail", con1));
                SqlParameter mail = new SqlParameter("@mail", admin.email);
                command.Parameters.Add(mail);
                string name11 = (string)command.ExecuteScalar();
                pass_email_txtbox.Text = name11;
                pass_email_txtbox.ReadOnly = true;
                SqlCommand command1 = (new SqlCommand("SELECT name FROM Driver WHERE email=@mail1", con1));
                SqlParameter mail1 = new SqlParameter("@mail1", admin.email);
                command1.Parameters.Add(mail1);
                string name12 = (string)command1.ExecuteScalar();
                pass_name_txtbox.Text = name12;

                SqlCommand command2 = (new SqlCommand("SELECT phone FROM Driver WHERE email=@mail2", con1));
                SqlParameter mail2 = new SqlParameter("@mail2", admin.email);
                command2.Parameters.Add(mail2);
                string name13 = (string)command2.ExecuteScalar();
                pass_phone_txtbox.Text = name13;

                SqlCommand command3 = (new SqlCommand("SELECT dr_password FROM Driver WHERE email=@mail2", con1));
                SqlParameter mail3 = new SqlParameter("@mail2", admin.email);
                command3.Parameters.Add(mail3);
                string name14 = (string)command3.ExecuteScalar();
                pass_passward_txtbox.Text = name14;
                con1.Close();
            }

            //data for passenger to admin show it
            if (first_page.ya != "" && admin.combo== "Passenger"&&admin.fun_type=="update")
            {
                con1.Open();
                SqlCommand command = (new SqlCommand("SELECT email FROM Passenger WHERE email=@mail", con1));
                SqlParameter mail = new SqlParameter("@mail", admin.email);
                command.Parameters.Add(mail);
                string name11 = (string)command.ExecuteScalar();
                pass_email_txtbox.Text = name11;
                pass_email_txtbox.ReadOnly = true;
                SqlCommand command1 = (new SqlCommand("SELECT name FROM Passenger WHERE email=@mail1", con1));
                SqlParameter mail1 = new SqlParameter("@mail1", admin.email);
                command1.Parameters.Add(mail1);
                string name12 = (string)command1.ExecuteScalar();
                pass_name_txtbox.Text = name12;

                SqlCommand command2 = (new SqlCommand("SELECT phone_number FROM Passenger WHERE email=@mail2", con1));
                SqlParameter mail2 = new SqlParameter("@mail2", admin.email);
                command2.Parameters.Add(mail2);
                string name13 = (string)command2.ExecuteScalar();
                pass_phone_txtbox.Text = name13;

                SqlCommand command3 = (new SqlCommand("SELECT password FROM Passenger WHERE email=@mail2", con1));
                SqlParameter mail3 = new SqlParameter("@mail2", admin.email);
                command3.Parameters.Add(mail3);
                string name14 = (string)command3.ExecuteScalar();
                pass_passward_txtbox.Text = name14;
                con1.Close();
            }


         
        }


        // back button
        private void button1_Click(object sender, EventArgs e)
        {
            admin.fun_type = "";
            admin.combo = "";
            admin.email = "";
            if (first_page.x == "sign")
            {
                first_page f = new first_page();
                f.MdiParent = this.MdiParent;
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else if (first_page.x == "admin")
            {
                admin ad = new admin();
                ad.MdiParent = this.MdiParent;
                this.Hide();
                ad.ShowDialog();
                this.Close();
            }
            else if (first_page.x == "driver")
            {
                driver ad = new driver();
                ad.MdiParent = this.MdiParent;
                this.Hide();
                ad.ShowDialog();
                this.Close();
            }
            else if (first_page.x == "pass")
            {
                passenger ad = new passenger();
                ad.MdiParent = this.MdiParent;
                this.Hide();
                ad.ShowDialog();
                this.Close();
            }
        }

      
        private void data_Load(object sender, EventArgs e)
        {
            pass_passward_txtbox.UseSystemPasswordChar = true;

        }

        //done button
        private void add_butt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   


            string name = pass_name_txtbox.Text;
            string email = pass_email_txtbox.Text;
            string phone = pass_phone_txtbox.Text;
            string password = pass_passward_txtbox.Text;
            //sign up 
            if (first_page.yp == "" && first_page.ya=="" && first_page.yd=="")
            {
                if (name == "" || email == "" || phone == "" || password == "")
                { MessageBox.Show("Enter All Data"); }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("addpassanger", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parm = new SqlParameter("@name", name);
                    cmd.Parameters.Add(parm);
                    SqlParameter parm2 = new SqlParameter("@email", email);
                    cmd.Parameters.Add(parm2);
                    SqlParameter parm3 = new SqlParameter("@phone", phone);
                    cmd.Parameters.Add(parm3);
                    SqlParameter parm4 = new SqlParameter("@passward", password);
                    cmd.Parameters.Add(parm4);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfuly Added");
                }
            }
            //update passanger data by himself
            else if (first_page.ya == "" && first_page.yd == "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Passenger set name ='" + pass_name_txtbox.Text + "'where email ='" + first_page.yp + "'", con);
                SqlCommand cmd1 = new SqlCommand("update Passenger set phone_number ='" + pass_phone_txtbox.Text + "'where email ='" + first_page.yp + "'", con);
                SqlCommand cmd2 = new SqlCommand("update Passenger set password ='" + pass_passward_txtbox.Text+ "'where email ='" + first_page.yp + "'", con);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("New Data Updated");
                con.Close();          
            }
            //update driver data by himself
            else if(first_page.yd!="")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Driver set name ='" + pass_name_txtbox.Text + "'where email ='" + first_page.yd + "'", con);
                SqlCommand cmd1 = new SqlCommand("update Driver set phone ='" + pass_phone_txtbox.Text + "'where email ='" + first_page.yd + "'", con);
                SqlCommand cmd2 = new SqlCommand("update Driver set dr_password ='" + pass_passward_txtbox.Text + "'where email ='" + first_page.yd + "'", con);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("New Data Updated");
                con.Close();
            }
            //admin
            else if (first_page.ya!="")
            {
                //update passanger data by admin
                if (admin.combo== "Passenger"&&admin.fun_type=="update")
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Passenger set name ='" + pass_name_txtbox.Text + "'where email ='" + admin.email + "'", con);
                    SqlCommand cmd1 = new SqlCommand("update Passenger set phone_number ='" + pass_phone_txtbox.Text + "'where email ='" + admin.email + "'", con);
                    SqlCommand cmd2 = new SqlCommand("update Passenger set password ='" + pass_passward_txtbox.Text + "'where email ='" + admin.email + "'", con);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("New Data Updated");
                    con.Close();
                }
                //add passanger by admin
                if(admin.combo== "Passenger"&&admin.fun_type=="add")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("addpassanger", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parm = new SqlParameter("@name", name);
                    cmd.Parameters.Add(parm);
                    SqlParameter parm2 = new SqlParameter("@email", email);
                    cmd.Parameters.Add(parm2);
                    SqlParameter parm3 = new SqlParameter("@phone", phone);
                    cmd.Parameters.Add(parm3);
                    SqlParameter parm4 = new SqlParameter("@passward", password);
                    cmd.Parameters.Add(parm4);
                    cmd.ExecuteNonQuery();
                   
                    con.Close();
                    MessageBox.Show("Successfuly Added");

                }
                //update driver data by admin
                if (admin.combo == "Driver" && admin.fun_type == "update")
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Driver set name ='" + pass_name_txtbox.Text + "'where email ='" + admin.email + "'", con);
                    SqlCommand cmd1 = new SqlCommand("update Driver set phone ='" + pass_phone_txtbox.Text + "'where email ='" + admin.email + "'", con);
                    SqlCommand cmd2 = new SqlCommand("update Driver set dr_password ='" + pass_passward_txtbox.Text + "'where email ='" + admin.email + "'", con);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("New Data Updated");
                    con.Close();
                }
                //add driver by admin 
                if (admin.combo == "Passenger" && admin.fun_type == "add")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("adddriver", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parm = new SqlParameter("@name", name);
                    cmd.Parameters.Add(parm);
                    SqlParameter parm2 = new SqlParameter("@email", email);
                    cmd.Parameters.Add(parm2);
                    SqlParameter parm3 = new SqlParameter("@phone", phone);
                    cmd.Parameters.Add(parm3);
                    SqlParameter parm4 = new SqlParameter("@passward", password);
                    cmd.Parameters.Add(parm4);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Successfuly Added");

                }

            }

        }
    }
}
