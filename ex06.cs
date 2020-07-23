using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int userInput = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine($"{i} * {i} = {i*i}");
            }

        }
    }
}

