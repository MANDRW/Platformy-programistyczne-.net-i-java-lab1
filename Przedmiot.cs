using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestProject1"), InternalsVisibleTo("WinKnap")]

namespace Knapsack
{
    class Przedmiot
    {
        private int id;
        private int value;
        private int weight;
        private float afordability;
        private bool isTaken;

        public Przedmiot(int id, int value, int weight)
        {
            this.id = id;
            this.value = value;
            this.weight = weight;
            this.afordability = (float)value / weight;
            this.isTaken = false;
        }

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }

        public float Afordability
        {
            get { return afordability; }
            set { this.afordability = value; }
        }

        public bool IsTaken
        {
            get { return isTaken; }
            set { this.isTaken = value; }
        }

        public override string ToString()
        {
            return "no.: " + id + " value: " + this.value + " weight: " + this.weight;
        }



    }
}
