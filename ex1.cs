using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to print");

            int userInput = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(i);
            }
           
        }
}
}
