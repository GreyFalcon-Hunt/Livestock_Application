using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStockFarm_Project
{
    public class Goat : Animal
    {
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
        public Goat() { }
        public Goat(int id, double aow, double dc, double wht, int ag, string clr, double aom)
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
        public override double Profitability()
        {
            double water = 0, dailycost = 0, milk = 0, tax = 0, income = 0, weight = 0;
            foreach (KeyValuePair<int, Goat> goat in Database.goats)
            {
                water = water + goat.Value.AmountOfWater;
                dailycost = dailycost + goat.Value.DailyCost;
                milk = milk + goat.Value.AmountOfMilk;
                weight = weight + goat.Value.Weight;
            }
            tax = (weight * Rates.govtTax);
            income = milk * Rates.goatMilkPrice; water = water * Rates.waterPice;
            return income - (tax + dailycost + water);
        }
        public override void SingleAnimalProfitability()
        {
            double water = 0, dailycost = 0, milk = 0, tax = 0, income = 0, weight = 0;
            foreach (KeyValuePair<int, Goat> goat in Database.goats)
            {
                water = goat.Value.AmountOfWater; water = water * Rates.waterPice;
                dailycost = goat.Value.DailyCost;
                milk = goat.Value.AmountOfMilk;
                weight = weight + goat.Value.Weight;
                tax = (weight * Rates.govtTax);
                income = (milk * Rates.goatMilkPrice) - (tax + dailycost + water);
                Database.arr.Add(goat.Value.ID, income);
            }
        }
    }
}
