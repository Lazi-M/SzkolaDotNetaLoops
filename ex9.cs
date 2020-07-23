using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which numbers you want to extract?\n " +
                "1. Even\n" +
                "2. Odd");
            int userInput = Int32.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Even();
                    break;
                case 2:
                    Odd();
                    break;
                default:
                    break;
            }


        }

        static void Even()
        {
            Console.WriteLine("Choose range, give me 2 numbers from x to y");
            int userInputX = Int32.Parse(Console.ReadLine());
            int userInputY = Int32.Parse(Console.ReadLine());

            for (int i = userInputX; i < userInputY; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        static void Odd()
        {
            Console.WriteLine("Choose range, give me 2 numbers from x to y");
            int userInputX = Int32.Parse(Console.ReadLine());
            int userInputY = Int32.Parse(Console.ReadLine());

            for (int i = userInputX; i < userInputY; i++)
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

