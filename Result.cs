﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestProject1"), InternalsVisibleTo("WinKnap")]

namespace Knapsack
{
    class Result
    {
        private List<int> numbers;
        private int sumValue;
        private int sumWeight;

        public Result()
        {
            this.numbers = new List<int>();
            this.sumValue = 0;
            this.sumWeight = 0;
        }
        public List<int> Numbers
        {
            get { return numbers; }
            set { this.numbers = value; }
        }
        public int SumValue
        {
            get { return sumValue; }
            set { this.sumValue = value; }
        }
        public int SumWeight
        {
            get { return sumWeight; }
            set { this.sumWeight = value; }
        }

        public override string ToString()
        {
            string str = "items: ";
            foreach (int number in this.numbers)
            {
                str += number + " ";
            }
            str += "\n";
            str += "\n" + "sumValue: " + this.sumValue + "\n";
            str += "sumWeight: " + this.sumWeight + "\n";

            return str;
        }
    }
}
