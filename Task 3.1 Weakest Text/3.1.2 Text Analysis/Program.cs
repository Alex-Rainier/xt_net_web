using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2_Text_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text for analysis... \n");

            string strForAnalysis = Console.ReadLine();
            //string strForAnalysis = "Now I have done what I can, he thought.\n" +
            //    "Let him begin to circle and let the fight come.\n";

            Console.WriteLine("Entered text: \n" + strForAnalysis);

            char[] separator = { ' ', ',', '.', '?', '!', '-', ':', ';' };

            string[] words = strForAnalysis.ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCounter = new Dictionary<string, int>();

            foreach (string el in words)
            {
                if (wordCounter.ContainsKey(el))
                {
                    wordCounter[el]++;
                }
                else
                {
                    wordCounter.Add(el, 1);
                }
            }

            foreach(var pair in wordCounter.OrderByDescending(pair => pair.Value))
            {
                if (pair.Value >= 3)
                {
                    int repetitionRate = pair.Value * 100 / words.Length;

                    if(repetitionRate > 5)
                    {
                        Console.WriteLine("\n" + $"You have used this word \"{pair.Key}\" {pair.Value} times, " +
                            $"it's too much for this text!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You have no frequently repeated words :)");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
