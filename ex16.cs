using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length of side: ");
            var sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Input length of side: ");
            var sideB = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sideA; i++)
            {
                for (int j = 0; j <= sideB; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
      
        
       
    }
}

