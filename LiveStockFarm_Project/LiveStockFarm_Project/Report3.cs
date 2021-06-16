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
    public partial class Report3 : Form
    {
        public Report3()
        {
            InitializeComponent();
        }

        private void Report3_Load(object sender, EventArgs e)
        {
            double cows = 0, goats = 0, jcows = 0;
            foreach (KeyValuePair<int, Goat> goat in Database.goats)
            {
                goats = goats + goat.Value.Weight;
            }
            foreach (KeyValuePair<int, JersyCow> jcow in Database.jersycows)
            {
                jcows = jcows + jcow.Value.Weight;
            }
            foreach (KeyValuePair<int, Cow> cow in Database.cows)
            {
                cows = cows + cow.Value.Weight;
            }

            totalcows.Text = ((cows * Rates.govtTax)*30).ToString();
            totaljcows.Text = (jcows * (Rates.govtTax + Rates.jersyCowTax) * 30).ToString();
            totalgoats.Text = ((goats * Rates.govtTax) * 30).ToString();
            totaltax.Text = (double.Parse(totalcows.Text)+double.Parse(totaljcows.Text)+double.Parse(totalgoats.Text)).ToString();
        }
    }
}
