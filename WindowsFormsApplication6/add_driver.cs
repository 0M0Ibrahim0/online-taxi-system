using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class add_driver : Form
    {
        public add_driver()
        {
            InitializeComponent();
        }

        private void add()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            con.Open();
            SqlCommand command = new SqlCommand("driver_add",con);
            command.CommandType = CommandType.StoredProcedure;
            /* stored procedure 
           create proc driver_add
                  @name nvarchar(50),@password nvarchar(50),@email nvarchar(50),@phone nvarchar(50),@salary int ,@license_num nvarchar(50)
                  as
                   insert into Driver (name,dr_password,email,phone,salary,license_num) values (@name,@password,@email,@phone,@salary,@license_num)

             */
            SqlParameter license_num = new SqlParameter("@license_num", license_num_txtbox.Text);
            command.Parameters.Add(license_num);
            SqlParameter name = new SqlParameter("@name", name_txtbox.Text);
            command.Parameters.Add(name);
            SqlParameter password = new SqlParameter("@password", passward_txtbox.Text);
            command.Parameters.Add(password);
            SqlParameter email = new SqlParameter("@email", email_txtbox.Text);
            command.Parameters.Add(email);
            SqlParameter phone = new SqlParameter("@phone",phone_txtbox.Text);
            command.Parameters.Add(phone);
            SqlParameter salary = new SqlParameter("@salary", int.Parse(salary_txtbox.Text));
            command.Parameters.Add(salary);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void add_butt_Click(object sender, EventArgs e)
        {
            add();
        }

        private void add_driver_Load(object sender, EventArgs e)
        {

        }
    }
}
