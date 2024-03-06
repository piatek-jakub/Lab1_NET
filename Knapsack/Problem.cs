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
        public List<Item> items;
        Problem()
        {
            items = new List<Item>();
            n = 0;
        }
        public Problem(int n, int seed)
        {
            this.n = n;
            items = new List<Item>();
            Random random = new Random(seed);
            for (int i  = 0; i < n; i++)
            {
                Item item = new Item(random.Next(1, 10), random.Next(1, 10), i);
                items.Add(item);
            }
        }
        public Result Solve(int capacity) 
        {
            Result result = new Result();
            return result;
        }
        /*public override string ToString()
        {

        }*/
    }
}
