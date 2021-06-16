using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStockFarm_Project
{
    public class Dog : Animal
    {
        string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Dog() { }
        public Dog(int id, double aow, double wht, int ag, string clr, double dc)
            : base(id, aow, dc, wht, ag)
        {
            this.ID = id;
            this.AmountOfWater = aow;
            this.DailyCost = dc;
            this.Weight = wht;
            this.Age = ag;
            this.color = clr;
        }
    }
}
