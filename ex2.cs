using System;

namespace SzkolaDotNetaLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose your start number");
            int userInputStart = Int32.Parse(Console.ReadLine());

            Console.WriteLine("To which number should i print");
            int userInputLenght = Int32.Parse(Console.ReadLine());


            for (int i = userInputStart; i <= userInputLenght; i++)
            {
                Console.WriteLine(i);
            }
           
        }
}
}
