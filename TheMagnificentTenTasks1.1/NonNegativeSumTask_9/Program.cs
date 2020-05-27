using System;

namespace NonNegativeSumTask_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            var random = new Random();

            int result = 0;

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }

            Console.WriteLine(string.Join(" ", array));

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    result += array[i];
                }
            }

            Console.WriteLine("The sum of all non-negative numbers is... " + result);

            Console.ReadKey();
        }
    }
}
