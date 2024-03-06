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
            this.items = new List<Item>();

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
            items.Sort(compareItems);
            foreach (var item in items)
            {
                Console.WriteLine("ID:" + item.ID + " value:" + item.value + " weight: " + item.weight + " ratio: " + item.ratio);
            }
            return result;
        }

        public int compareItems(Item x, Item y)
        {
            if(x.ratio == y.ratio) return 0;
            else if(x.ratio > y.ratio) return -1;
            else return 1;
        }
        /*public override string ToString()
{

}*/
    }
}
