using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length of height: ");
            var height = int.Parse(Console.ReadLine());

     

            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
      
        
       
    }
}

