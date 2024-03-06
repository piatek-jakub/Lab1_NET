﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    internal class Result
    {
        public int weightSum;
        public int valueSum;
        public List<int> listID;
        public Result()
        {
            this.weightSum = 0;
            this.valueSum = 0;
            this.listID = new List<int>();
        }

        public override string ToString()
        {
            string str = "";
            str += "items: ";
            foreach(var id in this.listID)
            {
                str+= id.ToString() + " ";
            }
            str += "\n";

            str += "total value: " + this.valueSum + "\n";
            str += "total weight: " + this.weightSum + "\n";
            return str;
        }
    }
}
