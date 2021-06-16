using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStockFarm_Project
{
    public class Cow : Animal//inheritance from Animal class
    {
        //additional attributes for cow
        string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        double amountOfMilk;
        public double AmountOfMilk
        {
            get { return amountOfMilk; }
            set { amountOfMilk = value; }
        }
        // default and parmeterized constructor.
        public Cow() { }
        public Cow(int id, double aow, double dc, double wht, int ag, string clr, double aom)
            : base(id, aow, dc, wht, ag)
        {
            this.ID = id;
            this.AmountOfWater = aow;
            this.DailyCost = dc;
            this.Weight = wht;
            this.Age = ag;
            this.color = clr;
            this.amountOfMilk = aom;
        }

        //Profit of all animals of cow type.
        public override double Profitability()
        {
            double water = 0, dailycost = 0, milk = 0, tax = 0, income = 0, weight = 0;
            foreach (KeyValuePair<int, Cow> cow in Database.cows)//search for each cow in cow hash  table.
            {
                water = water + cow.Value.AmountOfWater;//add water consumption of all cows
                dailycost = dailycost + cow.Value.DailyCost;//add daily cost of all cows
                milk = milk + cow.Value.AmountOfMilk;//add milk of all cows
                weight = weight + cow.Value.Weight;
            }
            tax = (weight * Rates.govtTax);//for tax we simply multiply tax rate with total weight and then minus total amount from that amount.
            income = milk * Rates.cowMilkPrice;//income is income multiplies with milk rate
            water = water * Rates.waterPice;//water is water multiplies with water rate
            return income-(tax+dailycost+water);//profit is income - expenses(expenses are tax,water,daily cost)
        }
        public override void SingleAnimalProfitability()
        {
            double water = 0, dailycost = 0, milk = 0, tax = 0, income = 0,weight=0;
            foreach (KeyValuePair<int, Cow> cow in Database.cows)
            {
                //it is same as above but here we do calculation for a single animal and save it into has table named arr.
                water = cow.Value.AmountOfWater;
                water = water * Rates.waterPice;
                dailycost = cow.Value.DailyCost;
                milk = cow.Value.AmountOfMilk;
                weight = weight + cow.Value.Weight;
                tax = (weight * Rates.govtTax);
                income = (milk * Rates.cowMilkPrice) - (tax + dailycost + water);
                Database.arr.Add(cow.Value.ID, income);
            }
        }

    }
}
