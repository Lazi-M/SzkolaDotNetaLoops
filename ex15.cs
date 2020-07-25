using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length of side: ");
            var side = int.Parse(Console.ReadLine());

            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
      
        
       
    }
}

