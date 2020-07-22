using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To which number should i print");

            int userInput = Int32.Parse(Console.ReadLine());

            while (userInput > 0)
            {
                Console.WriteLine(userInput);
                userInput--;
            }

            while (userInput < 0)
            {
                Console.WriteLine(userInput);
                userInput++;
            }



        }
    }
}
