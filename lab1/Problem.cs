﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Problem
    {
        private int quantity;
        private List<Przedmiot> items;

        public Problem(int quantity, int seed)
        {
            this.quantity = quantity;
            this.items = new List<Przedmiot>();
            Random rand = new Random(seed);
            for (int i = 0; i < quantity; i++)
            {
                Przedmiot item = new Przedmiot(i,rand.Next(1,10),rand.Next(1,10));
                this.items.Add(item);
            }
        }

        public Result Solve (int capacity)
        {
            Items.Sort((x, y) => y.Afordability.CompareTo(x.Afordability));
            Result result = new Result();
            for (int i = 0; i < quantity; i++)
            {
                if (Items[i].Weight + result.SumWeight <= capacity)
                {
                    result.Numbers.Add(items[i].Id);
                    result.SumValue += Items[i].Value;
                    result.SumWeight += Items[i].Weight;
                    Items[i].IsTaken = true;
                }
            }
            return result;
        }

        public int Quantity
        {
            get { return quantity; }
            set { this.quantity = value; }
        }
       

        public List<Przedmiot> Items
        {
            get { return items; }
            set { this.items = value; }
        }

        public override string ToString()
        {
            string str = "";
            foreach (Przedmiot item in this.items)
            {
                str += item.ToString() + "\n";
            }
            return str;
        }
    }
}
