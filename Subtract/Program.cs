
using System;

namespace Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;

            int result = 0;

            Console.Write("Enter first number: ");
            firstNumber  = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            secondNumber  = int.Parse(Console.ReadLine());


            result = firstNumber - secondNumber;
            Console.WriteLine("The result is: "+ result);
        }
    }
}
