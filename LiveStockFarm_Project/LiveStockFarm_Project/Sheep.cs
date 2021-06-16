using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStockFarm_Project
{
    public class Sheep : Animal
    {
        string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        double amountOfWool;
        public double AmountOfWool
        {
            get { return amountOfWool; }
            set { amountOfWool = value; }
        }
        public Sheep() { }
        public Sheep(int id, double aow, double dc, double wht, int ag, string clr, double aowool)
            : base(id, aow, dc, wht, ag)
        {
            this.ID = id;
            this.AmountOfWater = aow;
            this.DailyCost = dc;
            this.Weight = wht;
            this.Age = ag;
            this.color = clr;
            this.amountOfWool = aowool;
        }
        public override double Profitability()
        {
            double water = 0, dailycost = 0, wool = 0, tax = 0, income = 0, weight = 0;
            foreach (KeyValuePair<int, Sheep> sheep in Database.sheeps)
            {
                water = water + sheep.Value.AmountOfWater;
                dailycost = dailycost + sheep.Value.DailyCost;
                wool = wool + sheep.Value.amountOfWool;
                weight = weight + sheep.Value.Weight;
            }
            tax = (weight * Rates.govtTax); water = water * Rates.waterPice;
            income = wool * Rates.sheepWoolPrice;
            return income - (tax + dailycost + water);
        }
        public override void SingleAnimalProfitability()
        {
            double water = 0, dailycost = 0, wool = 0, tax = 0, income = 0, weight = 0;
            foreach (KeyValuePair<int, Sheep> sheep in Database.sheeps)
            {
                water = sheep.Value.AmountOfWater; water = water * Rates.waterPice;
                dailycost = sheep.Value.DailyCost;
                wool = sheep.Value.AmountOfWool;
                weight = weight + sheep.Value.Weight;
                tax = (weight * Rates.govtTax);
                income = (wool * Rates.sheepWoolPrice) - (tax + dailycost + water);
                Database.arr.Add(sheep.Value.ID, income);
            }
        }
    }
}
