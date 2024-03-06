using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    internal class Problem
    {
        public int n;
        List<Item> items;
        Problem()
        {
            items = new List<Item>();
            n = 0;
        }
        public Problem(int n, int seed)
        {
            this.n = n;
            items = new List<Item>();
            for(int i  = 0; i < n; i++)
            {
                Random random = new Random(seed);
                items.Add(new Item(random.Next(10), random.Next(10)));
            }
        }
    }
}
