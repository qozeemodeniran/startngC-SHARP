using System;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;
            
            int result = 0;

            Console.Write("Enter first number: ");
            numberOne = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            numberTwo = int.Parse(Console.ReadLine());

            result = numberOne / numberTwo;
            Console.WriteLine("The answer is: " + result);
        }
    }
}
