using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MSTest_Knapsack"), InternalsVisibleTo("WinFormsKnapsack")]
namespace Knapsack
{
    internal class Problem
    {
        public int n;
        public List<Item> items;
        public Problem()
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
                Item item = new Item(random.Next(1, 11), random.Next(1, 11), i);
                items.Add(item);
            }
        }

        public void AddItemsManually(List<Item> items) 
        {
            foreach(Item item in items)
            {
                this.items.Add(item);
            }
            n = items.Count;
        }

        public Result Solve(int capacity) 
        {
            Result result = new Result();

            if(capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Invalid capacity");
            }

            items.Sort(compareItems);
            /*foreach(var item in items)
            {
                Console.WriteLine("ID:" + item.ID + " value:" + item.value + " weight: " + item.weight + " ratio: " + item.ratio);
            }*/
            foreach (var item in items) 
            {
                if(result.weightSum + item.weight <= capacity && item.IsItemValid())
                {
                    result.valueSum += item.value;
                    result.weightSum += item.weight;
                    result.listID.Add(item.ID);

                    if(result.weightSum == capacity)
                    {
                        break;
                    }
                }
            }
            return result;
        }

        public int compareItems(Item x, Item y)
        {
            if(x.ratio == y.ratio) return 0;
            else if(x.ratio > y.ratio) return -1;
            else return 1;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in items)
            {
                str += "no.: " + item.ID + " value: " + item.value + " weight: " + item.weight + " ratio: " + item.ratio + Environment.NewLine;
            }
            return str;
        }
    }
}
