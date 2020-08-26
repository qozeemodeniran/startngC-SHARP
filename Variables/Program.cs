using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int personsAge = 99;
            string personsName = "Qozeem Odeniran";
            
            string myName = "";
            Console.WriteLine("Please Enter Your Name: ");
            myName = Console.ReadLine();


            Console.WriteLine(personsAge);
            Console.WriteLine(personsName);
            Console.WriteLine("Hello " + myName);
        }
    }
}
