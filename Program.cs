using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProject1"), InternalsVisibleTo("WinKnap")]


namespace Knapsack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the seed:");
            int seed = Convert.ToInt32(Console.ReadLine());

            Problem problem = new Problem(quantity, seed);

            Console.WriteLine(problem.ToString());

            Console.WriteLine("Enter the capacity:");
            int capacity = Convert.ToInt32(Console.ReadLine());

            Result result = problem.Solve(capacity);

            Console.WriteLine(result.ToString());
        }
    }
}
