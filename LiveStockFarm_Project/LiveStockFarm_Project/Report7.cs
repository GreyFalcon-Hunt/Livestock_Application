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
    public partial class Report7 : Form
    {
        public Report7()
        {
            InitializeComponent();
        }

        private void Report7_Load(object sender, EventArgs e)
        {
            double cow = 0, jcow = 0, goat = 0, sheep = 0, dog = 0; 
            foreach (KeyValuePair<int, Cow> cows in Database.cows)
            {
                cow = cow + cows.Value.DailyCost;
            }
            foreach (KeyValuePair<int, JersyCow> jcows in Database.jersycows)
            {
                jcow = jcow + jcows.Value.DailyCost;
            }
            foreach (KeyValuePair<int, Goat> goats in Database.goats)
            {
                goat = goat + goats.Value.DailyCost;
            }
            foreach (KeyValuePair<int, Sheep> sheeps in Database.sheeps)
            {
                sheep = sheep + sheeps.Value.DailyCost;
            }
            foreach (KeyValuePair<int, Dog> dogs in Database.dogs)
            {
                dog = dog + dogs.Value.DailyCost;
            }
            cowcost.Text=cow.ToString();
            jcowcost.Text=jcow.ToString();
            goatcost.Text=goat.ToString();
            dogcost.Text=dog.ToString();
            sheepcost.Text = sheep.ToString();
            totalcost.Text = (cow + goat + jcow + goat + dog).ToString();
        }
    }
}
