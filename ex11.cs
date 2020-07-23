using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {         
            
            Range();
        }

        static void Range()
        {
            
            Console.WriteLine("Choose range, give me 2 numbers from x to y");
            int userInputX = Int32.Parse(Console.ReadLine());
            int userInputY = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Choose divider");
            int userInput = Int32.Parse(Console.ReadLine());

            if (userInput == 2)
            {
                Console.WriteLine("Numbers divisible by 2: ");
                for (int i = userInputX; i < userInputY; i++)
                {
                    if (i % 2 != 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);

                }
            }

            else if (userInput == 3)
            {
                Console.WriteLine("Numbers divisible by 3: ");
                for (int i = userInputX; i < userInputY; i++)
                {
                    if (i % 3 != 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);

                }
            }

            else if (userInput == 4)
            {
                Console.WriteLine("Numbers divisible by 4: ");
                for (int i = userInputX; i < userInputY; i++)
                {
                    if (i % 4 != 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);

                }
            }

            else if (userInput == 5)
            {
                Console.WriteLine("Numbers divisible by 5: ");
                for (int i = userInputX; i < userInputY; i++)
                {
                    if (i % 5 != 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);

                }
            }


            else if (userInput == 7)
            {
                Console.WriteLine("Numbers divisible by 7: ");
                for (int i = userInputX; i < userInputY; i++)
                {
                    if (i % 7 != 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);

                }
            }

            else if (userInput == 9)
            {
                Console.WriteLine("Numbers divisible by 9: ");
                for (int i = userInputX; i < userInputY; i++)
                {
                    if (i % 9 != 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);

                }
            }
            else
            {
                Console.WriteLine("Wrong number");
            }

            
        }

        
    }
}

