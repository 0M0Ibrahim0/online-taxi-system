using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class promo : Form
    {
        public promo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.MdiParent = this.MdiParent;
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }
        private void add_promo()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Uber;Integrated Security=True"); // making connection   
            con.Open();
            /*
            the stored procedure code :
            //////////////////////////////////
            create proc add_promotion 
                   @code nvarchar(50),@expiry_date nvarchar(50),@apply_date nvarchar(50),@amount_of_discount nvarchar(50)
                     as
           insert into Promotion (code, [expiry_date],apply_date,amount_of_discount) values (@code,@expiry_date,@apply_date,@amount_of_discount)

            */
            SqlCommand com = new SqlCommand("add_promotion", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter expire_date = new SqlParameter("@expiry_date", expire_data_txtbox.Text);
            com.Parameters.Add(expire_date);
            SqlParameter apply_date = new SqlParameter("@apply_date", apply_data_txtbox.Text);
            com.Parameters.Add(apply_date);
            SqlParameter code = new SqlParameter("@code", code_txtbox.Text);
            com.Parameters.Add(code);
            SqlParameter discount = new SqlParameter("@amount_of_discount", discount_txtbox.Text);
            com.Parameters.Add(discount);
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully added");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_promo();
        }

        private void promo_Load(object sender, EventArgs e)
        {

        }
    }
}
