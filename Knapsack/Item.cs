using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    internal class Item
    {
        public int value;
        public int weight;
        public int ID;
        public float ratio;
        public Item(int value, int weight, int ID)
        {
            this.value = value;
            this.weight = weight;
            this.ID = ID;
            this.ratio = (float)value / (float)weight;
        }
    }

}
