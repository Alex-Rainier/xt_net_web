using System;

namespace AveragesTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string... ");

            string str = Console.ReadLine();

            if(str != "")
            {
                string[] words = str.Split(new[] { ' ', '.', ',', '?', '!', }, StringSplitOptions.RemoveEmptyEntries);

                float average = 0;

                for(int i = 0; i < words.Length; i++)
                {
                    average += words[i].Length;
                }

                average /= words.Length;

                Console.WriteLine("The average word length per line is... " + Math.Round(average, 1));
                // Решил оставить дробный результат
            }
            else
            {
                Console.WriteLine("You have not entered anything!");
            }

            Console.ReadKey();
        }
    }
}
