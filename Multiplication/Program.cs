using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;

            int result = 0;

            Console.Write("Supply first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Supply second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Supply third number: ");
            thirdNumber = int.Parse(Console.ReadLine());

            result = firstNumber * secondNumber * thirdNumber;
            
            Console.WriteLine("The multiplication of " + firstNumber + "," + secondNumber + "," + "and" + " " + thirdNumber  + " " + "is" + " " + result);
        }
    }
}
