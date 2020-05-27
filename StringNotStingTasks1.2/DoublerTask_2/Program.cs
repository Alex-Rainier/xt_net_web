using System;
using System.Linq;

namespace DoublerTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string... \n");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter the second string... \n");
            string secondString = Console.ReadLine();

            string finalString = null;

            foreach(char ch in firstString)
            {
                if (secondString.Contains(ch))
                {
                    finalString += ch;
                    finalString += ch;
                }
                else
                {
                    finalString += ch;
                }
            }

            Console.WriteLine("Result: " + finalString);

            Console.ReadKey();
        }
    }
}
