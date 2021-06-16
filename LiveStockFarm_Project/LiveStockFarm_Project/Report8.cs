using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LiveStockFarm_Project
{
    public partial class Report8 : Form
    {
        public Report8()
        {
            InitializeComponent();
        }

        //this struct will be used to store id and profit of all animals
        public struct sorting
            {
                public int id;
                public double profit;
            }
        private void Report8_Load(object sender, EventArgs e)
        {
            Database.arr.Clear();//clear the arr hash table as we will fill it again so no duplicate error occurs
            Cow c = new Cow();
            JersyCow jc = new JersyCow();
            Goat g = new Goat();
            Sheep s = new Sheep();
            //fill the hash table named arr with id and profit of all animals
            c.SingleAnimalProfitability();  
            jc.SingleAnimalProfitability();
            g.SingleAnimalProfitability();
            s.SingleAnimalProfitability();
            double tempVal; int tempid; int count=0;
            sorting[] data=new sorting[Database.arr.Count];//declare a struct array
            foreach(KeyValuePair<int,double> animal in Database.arr)//fill that array with hash table data
            {
                data[count].id = animal.Key;
                data[count].profit = animal.Value;
                count++;
            }
            for (int i = 0; i < Database.arr.Count; i++)//here is the array sorting algorithm
            {
                for (int j = i + 1; j < Database.arr.Count; j++)
                {
                    if (data[i].profit > data[j].profit)
                    {
                        tempid = data[i].id;
                        tempVal = data[i].profit;
                        data[i].id = data[j].id; 
                        data[i].profit = data[j].profit;  
                        data[j].id = tempid;
                        data[j].profit = tempVal;
                    }
                }
            }
            textBox1.Text = textBox1.Text + "Animal ID" + "                    " + "Profitability" + "\r\n";//fill textbox with the array data
            textBox1.Text = textBox1.Text + "****************************************************" + "\r\n";
            FileStream fs = new FileStream("sortedData.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < Database.arr.Count; i++)//save that data into text file
            {
                textBox1.Text = textBox1.Text + data[i].id.ToString() + "                                 " + data[i].profit.ToString() + "\r\n";
                
                sw.WriteLine(data[i].id);
            }
            sw.Close();
        }
    }
}

/*
 *Bubble Sort
 */