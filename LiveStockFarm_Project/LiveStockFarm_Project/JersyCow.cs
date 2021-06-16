using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStockFarm_Project
{
    public class JersyCow:Cow 
    {
        bool isJersy;

        public bool IsJersy
        {
            get { return isJersy; }
            set { isJersy = value; }
        }
        public JersyCow() { }
        public JersyCow(int id, double aow, double dc, double wht, int ag, string clr, double aom,bool ij)
            : base(id, aow, dc, wht, ag, clr, aom)
        {
            this.ID = id;
            this.AmountOfWater = aow;
            this.DailyCost = dc;
            this.Weight = wht;
            this.Age = ag;
            this.Color = clr;
            this.AmountOfMilk = aom;
            this.isJersy = ij;
        }
        public double totalMilk()//this returns the total milk of all jersy cows
        {
            double milk = 0;
            foreach (KeyValuePair<int, JersyCow> cow in Database.jersycows)
            {
                milk = milk + cow.Value.AmountOfMilk;
            }
            return milk;
        }
        public double totalWater()//this returns the total water consumption of all jersy cows
        {
            double water = 0;
            foreach (KeyValuePair<int, JersyCow> cow in Database.jersycows)
            {
                water = water + cow.Value.AmountOfWater;
            }
            return water;
        }
        public double dailycost()//this returns the total daily cost of all jersy cows
        {
            double dc = 0;
            foreach (KeyValuePair<int, JersyCow> cow in Database.jersycows)
            {
                dc = dc + cow.Value.DailyCost;
            }
            return dc;
        }
        //these functions are exactly similar as cow functions
        public override double Profitability()
        {
            double water = 0, dailycost = 0, milk = 0, tax = 0, income = 0,weight=0;
            foreach (KeyValuePair<int, JersyCow> cow in Database.jersycows)
            {
                water = water + cow.Value.AmountOfWater;
                dailycost = dailycost + cow.Value.DailyCost;
                milk = milk + cow.Value.AmountOfMilk;
                weight = weight + cow.Value.Weight;
            }
            tax = (weight * (Rates.govtTax+Rates.jersyCowTax));
            income = milk * Rates.cowMilkPrice; water = water * Rates.waterPice;
            return income - (tax + dailycost + water);
        }
        public override void SingleAnimalProfitability()
        {
            double water = 0, dailycost = 0, milk = 0, tax = 0, income = 0, weight = 0;
            foreach (KeyValuePair<int, JersyCow> cow in Database.jersycows)
            {
                water = cow.Value.AmountOfWater; water = water * Rates.waterPice;
                dailycost = cow.Value.DailyCost;
                milk = cow.Value.AmountOfMilk;
                weight = weight + cow.Value.Weight;
                tax = (weight * (Rates.govtTax+Rates.jersyCowTax));
                income = (milk * Rates.cowMilkPrice) - (tax + dailycost + water);
                Database.arr.Add(cow.Value.ID, income);
            }
        }
    }
}
