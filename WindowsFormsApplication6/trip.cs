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
    public partial class trip : Form
    {
        public trip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passenger p = new passenger();
            p.MdiParent = this.MdiParent;
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void Make_Trip_Click(object sender, EventArgs e)
        {
            passenger_data pd = new passenger_data();
            pd.MdiParent = this.MdiParent;
            this.Hide();
            pd.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            finish_trip ft = new finish_trip();
            ft.MdiParent = this.MdiParent;
            ft.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            car c = new car();
            c.ShowDialog();

        }

        private void trip_Load(object sender, EventArgs e)
        {

        }
    }
}
