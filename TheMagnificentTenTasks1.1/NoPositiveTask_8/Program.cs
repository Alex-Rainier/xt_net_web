using System;

namespace NoPositiveTask_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[3, 3, 3];

            var random = new Random();

            Console.WriteLine("Yes Positive \n");

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    for(int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(9);

                        Console.Write(array[i, j, k] + " ");
                    }
                }
            }

            Console.WriteLine("\n");

            Console.WriteLine("No Positive \n");

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    for(int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = 0;

                        Console.Write(array[i, j, k] + " ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
