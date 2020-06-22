using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1_Custom_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сравнение
            Console.WriteLine("Введите первую строку: ");
            MyStringBuilder test = new MyStringBuilder(Console.ReadLine());
            Console.WriteLine("Введите строку которую вы хотите сравнить с первой: ");
            Console.WriteLine(test.StringComparison(Console.ReadLine()));

            //Конкатенация
            Console.WriteLine("Введите строку для конкатенации с первой строкой: ");
            MyStringBuilder test2 = new MyStringBuilder(Console.ReadLine());
            MyStringBuilder concat = test + test2;
            Console.WriteLine(concat.MyToString());

            //Поиск
            Console.WriteLine("Введите символ для поиска: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine(test.MySearch(ch));

            //Из массива в строку
            char[] test3 = { 'H', 'e', 'l', 'l', 'o', '!' };
            test.MyToString(test3);
            Console.WriteLine(test3);

            //Из строки в массив
            char[] test4 = test.MyToArray("Hello!");
            foreach(char el in test4)
                Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
