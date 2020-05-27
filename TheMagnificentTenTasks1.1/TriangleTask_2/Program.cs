using System;

namespace TriangleTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to build a triangle... ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                for(int i = 0; i <= number; i++)
                {
                    Console.WriteLine(new String('*', i));
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
