using System;

namespace RectangleTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two sides of the rectangle to calculate the area: ");

            try
            {
                Console.WriteLine("Enter side X: ");
                float x = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter side Y: ");
                float y = float.Parse(Console.ReadLine());

                if(x <= 0 || y <= 0)
                {
                    Console.WriteLine("Numbers must not be less than zero!");
                }
                else
                {
                    Console.WriteLine("The area of the rectangle is... " + x * y);
                }
            }
            catch
            {
                Console.WriteLine("X or Y are not a number!");
            }

            Console.ReadKey();
        }
    }
}
