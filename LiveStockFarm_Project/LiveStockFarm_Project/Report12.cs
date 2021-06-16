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
    public partial class Report12 : Form
    {
        public Report12()
        {
            InitializeComponent();
        }

        private void Report12_Load(object sender, EventArgs e)
        {
            JersyCow jc=new JersyCow();
            income.Text = (jc.totalMilk() * Rates.cowMilkPrice).ToString();

            double tax = ((Rates.govtTax + Rates.jersyCowTax) * jc.totalMilk());
            expenses.Text = ((jc.totalWater() * Rates.waterPice) + (tax)+jc.dailycost()).ToString();

            profitability.Text = jc.Profitability().ToString();
        }
    }
}
