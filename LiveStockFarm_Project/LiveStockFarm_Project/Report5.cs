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
    public partial class Report5 : Form
    {
        public Report5()
        {
            InitializeComponent();
        }

        private void Report5_Load(object sender, EventArgs e)
        {
            int count = 0;
            int cow = 0, jcow = 0, goat = 0, sheep = 0;
            foreach (KeyValuePair<int, Cow> cows in Database.cows)
            {
                cow = cow + cows.Value.Age; count++;
            }
            foreach (KeyValuePair<int, JersyCow> jcows in Database.jersycows)
            {
                jcow = jcow + jcows.Value.Age; count++;
            }
            foreach (KeyValuePair<int, Goat> goats in Database.goats)
            {
                goat = goat + goats.Value.Age; count++;
            }
            foreach (KeyValuePair<int, Sheep> sheeps in Database.sheeps)
            {
                sheep = sheep + sheeps.Value.Age; count++;
            }
            cowage.Text = cow.ToString();
            goatage.Text = goat.ToString();
            sheepage.Text = sheep.ToString();
            jcowage.Text = jcow.ToString();
            avgage.Text = ((cow + jcow + goat + sheep) / count).ToString();
        }
    }
}
