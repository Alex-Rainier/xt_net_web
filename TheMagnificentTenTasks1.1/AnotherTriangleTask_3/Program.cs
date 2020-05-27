using System;

namespace AnotherTriangleTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to build a triangle... ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                for(int j = 1; number > 0; j+=2, number--)
                {
                    Console.WriteLine(new String(' ', number ) + new String('*', j));
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
