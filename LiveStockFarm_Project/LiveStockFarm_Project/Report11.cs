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
    public partial class Report11 : Form
    {
        public Report11()
        {
            InitializeComponent();
        }

        private void Report11_Load(object sender, EventArgs e)
        {
            

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(threshold.Text) > 0 || threshold.Text == "")
                {
                    int cow = 0, jcow = 0, goat = 0, sheep = 0, dog = 0, total = 0;
                    foreach (KeyValuePair<int, Cow> cows in Database.cows)
                    {
                        if (cows.Value.Age > int.Parse(threshold.Text))
                        {
                            cow++;
                        }
                        total++;
                    }
                    foreach (KeyValuePair<int, JersyCow> jcows in Database.jersycows)
                    {
                        if (jcows.Value.Age > int.Parse(threshold.Text))
                        {
                            jcow++;
                        }
                        total++;
                    }
                    foreach (KeyValuePair<int, Goat> goats in Database.goats)
                    {
                        if (goats.Value.Age > int.Parse(threshold.Text))
                        {
                            goat++;
                        }
                        total++;
                    }
                    foreach (KeyValuePair<int, Sheep> sheeps in Database.sheeps)
                    {
                        if (sheeps.Value.Age > int.Parse(threshold.Text))
                        {
                            sheep++;
                        }
                        total++;
                    }
                    foreach (KeyValuePair<int, Dog> dogs in Database.dogs)
                    {
                        if (dogs.Value.Age > int.Parse(threshold.Text))
                        {
                            dog++;
                        }
                        total++;
                    }
                    totalcows.Text = cow.ToString();
                    totaljcows.Text = jcow.ToString();
                    totalsheeps.Text = sheep.ToString();
                    totalgoats.Text = goat.ToString();
                    totaldogs.Text = dog.ToString();
                    totalanimals.Text = (cow + goat + dog + sheep + jcow).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter a valid age.");
            }
        }
       
    }
}
