using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To which number should i print");

            int userInput = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= userInput; i++)
            {
                Console.WriteLine(i);
            }
           
        }
}
}
