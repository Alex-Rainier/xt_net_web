using System;

namespace X_МasTreeTask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to build a Christmas Tree... ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                for(int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= 2 * i; j += 2)
                    {
                        for(int k = number; k >= j / 2 + 2; k--)
                        {
                            Console.Write(" ");
                        }
                        for(int k = 1; k <= j; k++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("You did not enter a number or enter nothing!");
            }

            Console.ReadKey();
        }
    }
}
