using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveStockFarm_Project
{
    public partial class Report6 : Form
    {
        public Report6()
        {
            InitializeComponent();
        }

        private void Report6_Load(object sender, EventArgs e)
        {
            Cow c = new Cow();
            Goat g = new Goat();
            Sheep s = new Sheep();
            cowprofit.Text = c.Profitability().ToString();
            goatprofit.Text = g.Profitability().ToString();
            sheepprofit.Text = s.Profitability().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
