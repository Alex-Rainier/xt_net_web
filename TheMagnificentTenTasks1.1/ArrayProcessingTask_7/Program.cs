using System;

namespace ArrayProcessingTask_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 0;
            int minValue = 100;

            int[] array = new int[50];

            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            Console.WriteLine("All array values: \n");

            Console.WriteLine(string.Join(" ", array));

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine("Maximum value: " + maxValue + "\n");

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1] && array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            Console.WriteLine("Minimum value: " + minValue + "\n");

            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array: \n");

            Console.WriteLine(string.Join(" ", array));

            Console.ReadKey();
        }
    }
}
