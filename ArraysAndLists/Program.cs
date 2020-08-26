using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] accountBalances = new int[5];

            accountBalances[0] = 10000;
            accountBalances[1] = 20000;
            accountBalances[2] = 30000;
            accountBalances[3] = 40000;
            accountBalances[4] = 50000;

            int sum = accountBalances.Sum();
            Console.WriteLine(sum);

            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Banana");
            fruits.Add("Orange"); 

            Console.WriteLine(fruits[0]);
        }
    }
}
