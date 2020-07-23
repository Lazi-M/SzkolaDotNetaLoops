using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNums();
        }

        static void PrimeNums()
        {
            Console.WriteLine("Choose range from x to y");
            int toRangeX = Int32.Parse(Console.ReadLine());
            int toRangeY = Int32.Parse(Console.ReadLine());

            for (int x = toRangeX; x < toRangeY; x++)
            {
                int primeN = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        primeN++;

                    if (primeN == 2) 
                        break;
                }
                if (primeN != 2)
                    Console.WriteLine(x);                                
            }            
        }
    }
}

