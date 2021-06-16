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
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            //According to the requirement, we just have to enter an id and check if an animal exist with this id.
            //we dont know that this animal is cow, dog, sheep etc.
            //so we check for all hash tables 
            int count = 0;//this is a counter.we will increment it if we find data in any hash table, else it will remain 0.
            //and if it zero at the end, then we will know that data doesn't exist.
            foreach (KeyValuePair<int, Cow> cow in Database.cows)//first check for cows
            {
                if (cow.Value.ID.ToString() == search_key.Text)//if found
                {
                    count++;//increment count
                    id.Text = cow.Value.ID.ToString();
                    aow.Text = cow.Value.AmountOfWater.ToString();
                    dc.Text = cow.Value.DailyCost.ToString();
                    wght.Text = cow.Value.Weight.ToString();
                    age.Text = cow.Value.Age.ToString();
                    color.Text = cow.Value.Color.ToString();
                    groupBox1.Visible = true; groupBox2.Visible = false;
                    cow_aom.Text = cow.Value.AmountOfMilk.ToString();
                    cow_ij.Text = "False";//as it is cow so jersy cow is false
                    at_label.Text = "Cow"; 
                    groupBox3.Visible = false; groupBox2.Visible = false;//hide the data boxes for goat sheep and dogs 
                    groupBox1.Visible = true;//only make cow box visible
                    break;
                }
            }
           // else search for other animals
            foreach (KeyValuePair<int, Dog> dog in Database.dogs)
            {
                if (dog.Value.ID.ToString() == search_key.Text)
                {
                    count++;
                    id.Text = dog.Value.ID.ToString();
                    aow.Text = dog.Value.AmountOfWater.ToString();
                    dc.Text = dog.Value.DailyCost.ToString();
                    wght.Text = dog.Value.Weight.ToString();
                    age.Text = dog.Value.Age.ToString();
                    color.Text = dog.Value.Color.ToString();
                    at_label.Text = "Dog"; groupBox1.Visible = false; groupBox2.Visible = false; groupBox3.Visible = false;
                    break;
                }
            }
            foreach (KeyValuePair<int, JersyCow> jcow in Database.jersycows)
            {
                if (jcow.Value.ID.ToString() == search_key.Text)
                {
                    count++;
                    id.Text = jcow.Value.ID.ToString();
                    aow.Text = jcow.Value.AmountOfWater.ToString();
                    dc.Text = jcow.Value.DailyCost.ToString();
                    wght.Text = jcow.Value.Weight.ToString();
                    age.Text = jcow.Value.Age.ToString();
                    color.Text = jcow.Value.Color.ToString();
                    cow_aom.Text = jcow.Value.AmountOfMilk.ToString();
                    cow_ij.Text = "True";
                    at_label.Text = "Jersy Cow"; groupBox1.Visible = true; groupBox2.Visible = false; groupBox3.Visible = false;
                    break;
                }
            }
            foreach (KeyValuePair<int, Sheep> sheep in Database.sheeps)
            {
                if (sheep.Value.ID.ToString() == search_key.Text)
                {
                    count++;
                    id.Text = sheep.Value.ID.ToString();
                    aow.Text = sheep.Value.AmountOfWater.ToString();
                    dc.Text = sheep.Value.DailyCost.ToString();
                    wght.Text = sheep.Value.Weight.ToString();
                    age.Text = sheep.Value.Age.ToString();
                    color.Text = sheep.Value.Color.ToString();
                    aowool.Text = sheep.Value.AmountOfWool.ToString();
                    at_label.Text = "Sheep"; groupBox1.Visible = false; groupBox2.Visible = true; groupBox3.Visible = false;
                    break;
                }
            }
            foreach (KeyValuePair<int, Goat> goat in Database.goats)
            {
                if (goat.Value.ID.ToString() == search_key.Text)
                {
                    count++;
                    id.Text = goat.Value.ID.ToString();
                    aow.Text = goat.Value.AmountOfWater.ToString();
                    dc.Text = goat.Value.DailyCost.ToString();
                    wght.Text = goat.Value.Weight.ToString();
                    age.Text = goat.Value.Age.ToString();
                    color.Text = goat.Value.Color.ToString();
                    goatmilk.Text = goat.Value.AmountOfMilk.ToString();
                    at_label.Text = "Goat"; groupBox1.Visible = false; groupBox2.Visible = false; groupBox3.Visible = true;
                    break;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Data not Found.");
            }
        }

        private void Report1_Load(object sender, EventArgs e)
        {

        }
    }
}
