using System;

namespace LowercaseTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string... ");

            string str = Console.ReadLine();

            int result = 0;

            if (str != "")
            {
                string[] words = str.Split(new[] { ' ', '.', ',', '?', '!', ':', ';', '-', '_'}, StringSplitOptions.RemoveEmptyEntries);

                foreach(string el in words)
                {
                    if (char.IsLower(el[0]))
                    {
                        result++;
                    }
                }

                Console.WriteLine("Number of words starting with a lowercase letter: " + result);
            }
            else
            {
                Console.WriteLine("You have not entered anything!");
            }

            Console.ReadKey();
        }
    }
}
