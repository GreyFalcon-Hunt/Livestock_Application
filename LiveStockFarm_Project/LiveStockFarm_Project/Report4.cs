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
    public partial class Report4 : Form
    {
        public Report4()
        {
            InitializeComponent();
        }

        private void Report4_Load(object sender, EventArgs e)
        {
            double cow = 0, jersycow = 0, goat = 0;
            foreach (KeyValuePair<int, Cow> cows in Database.cows)
            {
                cow = cow + cows.Value.AmountOfMilk;
            }
            foreach (KeyValuePair<int, JersyCow> jcows in Database.jersycows)
            {
                jersycow = jersycow + jcows.Value.AmountOfMilk;
            }
            foreach (KeyValuePair<int, Goat> goats in Database.goats)
            {
                goat = goat + goats.Value.AmountOfMilk;
            }
            cowmilk.Text = cow.ToString();
            jcowmilk.Text = jersycow.ToString();
            goatmilk.Text = goat.ToString();
            total.Text = (cow + jersycow + goat).ToString();
        }
    }
}
