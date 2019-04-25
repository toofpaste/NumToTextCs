using System;

namespace NumbersToWords
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("A to run: Q to quit");
            bool check = Console.ReadLine().ToUpper() == "Q";

            while (!check)
            {
                Console.WriteLine("Enter a number: ");
                int num1 = int.Parse(Console.ReadLine());


                Numbers num = new Numbers(num1);

                Console.WriteLine(num.NumToWords(num.GetNum()));
            }
        }
    }
}
