using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class passenger : Form
    {
        public passenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first_page.yp = "";
            first_page.x = "";
            first_page f = new first_page();
            f.MdiParent = this.MdiParent;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passenger_data pd = new passenger_data();
            pd.MdiParent = this.MdiParent;
            this.Hide();
            pd.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            data d = new data();
            d.MdiParent = this.MdiParent;
            this.Hide();
            d.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trip t = new trip();
            t.MdiParent = this.MdiParent;
            this.Hide();
            t.ShowDialog();
            this.Close();
        }

        private void passenger_Load(object sender, EventArgs e)
        {

        }
    }
}
