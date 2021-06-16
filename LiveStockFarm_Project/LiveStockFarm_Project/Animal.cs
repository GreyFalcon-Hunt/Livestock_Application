using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStockFarm_Project
{
    public class Animal  //this is the main Parent class.
    {
        //it contains all the common attributes of all the farm animals like id,water,cost,weight and age.
        //these atrributes are common to all but rest are specific to each animal.
        //private attributes with public get/set methods.
        int Id;
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        double amountOfWater;
        public double AmountOfWater
        {
            get { return amountOfWater; }
            set { amountOfWater = value; }
        }
        double dailyCost;
        public double DailyCost
        {
            get { return dailyCost; }
            set { dailyCost = value; }
        }
        double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //default and parameterized constructor
        public Animal() { }
        public Animal(int id, double aow, double dc, double wht, int ag)
        {
            this.Id = id;
            this.amountOfWater = aow;
            this.dailyCost = dc;
            this.weight = wht;
            this.age = ag;
        }
        //virtual functions
        public virtual double Profitability() { return 1; }//this function calcualtes profitability of all animals of one type.
                                                           //like for cows, it will calculate profit for all cows.
        public virtual void SingleAnimalProfitability() {  }//this function calcualtes profitability of single animal of one type.
                                                           //like for cows, it will calculate profit for only one cow.
    }
}
