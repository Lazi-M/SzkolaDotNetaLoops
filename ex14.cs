using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc();
        }
        static void Calc()
        {
            Console.WriteLine("Type a number");
            int firstNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Type another number");
            int secondNum = Int32.Parse(Console.ReadLine());


            Console.WriteLine("\nWhat do you want to count:\n" +
                "1. Adding\n" +
                "2. Substracting\n" +
                "3. Multipling\n" +
                "4. Diving\n");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Result: {firstNum} + {secondNum} = " + (firstNum + secondNum));
                    break;
                case "2":
                    Console.WriteLine($"Result: {firstNum} - {secondNum} = " + (firstNum - secondNum));
                    break;
                case "3":
                    Console.WriteLine($"Result: {firstNum} * {secondNum} = " + (firstNum * secondNum));
                    break;
                case "4":
                    Console.WriteLine($"Result: {firstNum} / {secondNum} = " + (firstNum / secondNum));
                    break;
            }

            Console.WriteLine("\nShall we continue or exit: \n" +
                "1. Continue\n" +
                "2. Exit");            
            int userInput = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (userInput)
            {
                case 1:
                    Calc();
                    break;
                case 2:
                    Environment.Exit(0);                                       
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }
        
       
    }
}

