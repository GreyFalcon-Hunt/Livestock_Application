using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStockFarm_Project
{
    public static class Database
    {
        public static Dictionary<int, Cow> cows = new Dictionary<int, Cow>();
        public static Dictionary<int, JersyCow> jersycows = new Dictionary<int, JersyCow>();
        public static Dictionary<int, Goat> goats = new Dictionary<int, Goat>();
        public static Dictionary<int, Sheep> sheeps = new Dictionary<int, Sheep>();
        public static Dictionary<int, Dog> dogs = new Dictionary<int, Dog>();
        public static Dictionary<int,double> arr=new Dictionary<int,double>();
    }
}
