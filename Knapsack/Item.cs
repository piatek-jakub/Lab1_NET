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
        public Item(int value, int weight)
        {
            this.value = value;
            this.weight = weight;
        }
    }

}
