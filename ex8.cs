using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 != 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}

