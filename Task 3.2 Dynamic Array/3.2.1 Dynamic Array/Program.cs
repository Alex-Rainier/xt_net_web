using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._1_Dynamic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Объявление коллекции без параметров: ");

            MyDynamicArray<int> dynamicArr1 = new MyDynamicArray<int>();

            foreach (var el in dynamicArr1)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine("\n" + "Установленная размерность коллекции: " + dynamicArr1.Capacity);

            int[] arr1 = { 5, 7, 13, 27, 39, 77 };

            MyDynamicArray<int> dynamicArr2 = new MyDynamicArray<int>(arr1);

            Console.WriteLine("\n" + "Объявление коллекции с параметрами: ");

            foreach(var el in dynamicArr2)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine("\n" + "Установленная размерность коллекции: " + dynamicArr2.Capacity);

            int[] arr2 = { 1, 2, 3, 4 };

            dynamicArr2.AddRange(arr2);

            Console.WriteLine("\n" + "Размерность первой коллекции при добавлении нескольких элементов: " + dynamicArr2.Capacity);

            for (int i = 0; i < dynamicArr2.Length; i++)
            {
                Console.Write(dynamicArr2[i] + " ");
            }

            Console.WriteLine();

            dynamicArr2.Remove(13);

            Console.WriteLine("\n" + "Размерность коллекции при удалении элемента: " + dynamicArr2.Capacity);

            Console.WriteLine("Длинна коллекции при удалении элемента: " + dynamicArr2.Length);

            for (int i = 0; i < dynamicArr2.Length; i++)
            {
                Console.Write(dynamicArr2[i] + " ");
            }

            Console.WriteLine();

            dynamicArr2.Insert(27, 3);

            Console.WriteLine("\n" + "Вставляем элемент \"27\", по индексу \"3\"");

            for (int i = 0; i < dynamicArr2.Length; i++)
            {
                Console.Write(dynamicArr2[i] + " ");
            }

            Console.WriteLine();

            dynamicArr2.Add(5);

            Console.WriteLine("\n" + "Размерность коллекции при добавлении элемента в конец: " + dynamicArr2.Capacity);
            Console.WriteLine("Длинна коллекции: " + dynamicArr2.Length);

            for (int i = 0; i < dynamicArr2.Length; i++)
            {
                Console.Write(dynamicArr2[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
