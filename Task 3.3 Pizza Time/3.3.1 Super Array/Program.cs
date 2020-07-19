using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1_Super_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 7, 19, 27, 27, 27, 54, 99, 108 };

            Console.WriteLine("Массив: ");

            foreach (int el in array)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\n" + "Сумма элементов: " + array.GetSum());
            Console.WriteLine("\n" + "Среднее значение элементов: " + array.GetAverage());
            Console.WriteLine("\n" + "Часто повторяется значение: " + array.Reiteration() + "\n");

            Console.WriteLine("Перебор массива с возведением в степень: ");

            array.ExtensionForeach(el => el * el);

            foreach (int el in array)
            {
                Console.Write(el + " ");
            }

            Console.ReadKey();
        }
    }
}
