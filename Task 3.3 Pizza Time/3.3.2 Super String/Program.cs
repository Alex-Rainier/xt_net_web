using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._2_Super_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string ru = "Привет";
            Console.WriteLine(ru + ": " + ru.Language());

            string en = "Hello";
            Console.WriteLine(en + ": " + en.Language());

            string num = "123";
            Console.WriteLine(num + ": " + num.Language());

            string mix = "Hello Мир!";
            Console.WriteLine(mix + ": " + mix.Language());

            Console.ReadKey();
        }
    }
}