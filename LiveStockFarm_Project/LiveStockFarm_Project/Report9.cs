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
    public partial class Report9 : Form
    {
        public Report9()
        {
            InitializeComponent();
        }

        private void Report9_Load(object sender, EventArgs e)
        {
            int cow = 0, jcow = 0, goat = 0, sheep = 0, dog = 0, total = 0;
            foreach (KeyValuePair<int, Cow> cows in Database.cows)
            {
                if(cows.Value.Color=="Red")
                {
                    cow++;
                }
                total++;
            }
            foreach (KeyValuePair<int, JersyCow> jcows in Database.jersycows)
            {
                if (jcows.Value.Color == "Red")
                {
                    jcow++;
                }
                total++;
            }
            foreach (KeyValuePair<int, Goat> goats in Database.goats)
            {
                if (goats.Value.Color == "Red")
                {
                    goat++;
                }
                total++;
            }
            foreach (KeyValuePair<int, Sheep> sheeps in Database.sheeps)
            {
                if (sheeps.Value.Color == "Red")
                {
                    sheep++;
                }
                total++;
            }
            foreach (KeyValuePair<int, Dog> dogs in Database.dogs)
            {
                if (dogs.Value.Color == "Red")
                {
                    dog++;
                }
                total++;
            }
            redcow.Text = cow.ToString();
            redjcow.Text = jcow.ToString();
            redgoat.Text = goat.ToString();
            redsheep.Text = sheep.ToString();
            reddog.Text = dog.ToString();
            totalanimals.Text = total.ToString();
            totalred.Text = (cow + goat + jcow + dog + sheep).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
