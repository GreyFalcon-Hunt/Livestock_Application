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
    public partial class Report10 : Form
    {
        public Report10()
        {
            InitializeComponent();
        }

        private void Report10_Load(object sender, EventArgs e)
        {
            double milk = 0, income = 0, tax = 0; 
            foreach (KeyValuePair<int, JersyCow> jcows in Database.jersycows)
            {
                milk = milk + jcows.Value.AmountOfMilk;
            }
            income = milk * Rates.cowMilkPrice;
            tax = (income * (Rates.govtTax + Rates.jersyCowTax));
            totalmilk.Text = milk.ToString();
            totalincome.Text = income.ToString();
            taxperday.Text = tax.ToString();
            yeartax.Text = (tax * 365).ToString();
        }
    }
}
