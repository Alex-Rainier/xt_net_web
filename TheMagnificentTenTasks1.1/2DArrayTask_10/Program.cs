using System;

namespace _2DArrayTask_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];

            var random = new Random();

            int result = 0;

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(9);

                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine("\n");

            for(int i = 0; i <= 1; i++)
            {
                for(int j = 0; j <= 2; j++)
                {
                    if((i + j) % 2 == 0)
                    {
                        result = result + array[i, j];
                    }
                }
            }

            Console.WriteLine("The sum of array elements standing in even positions is... " + result);

            Console.ReadKey();
        }
    }
}
