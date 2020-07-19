using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._1_Weakest_Link
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество человек стоящих в кругу: ");

            if (int.TryParse(Console.ReadLine(), out int numberOfPeople) && numberOfPeople > 0)
            {
                Console.WriteLine("Человек под каким номером будет удален?");

                if (int.TryParse(Console.ReadLine(), out int numberOfDeletePerson) && numberOfDeletePerson > 0 &&
                    numberOfDeletePerson != 1)
                {
                    for(int i = 1; i <= numberOfPeople - numberOfDeletePerson + 1; i++)
                    {
                        Console.WriteLine($"Раунд {i}. Человек вычеркнут. Людей осталось {numberOfPeople - i}");

                        if(i == numberOfPeople - numberOfDeletePerson + 1)
                            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
                    }
                }
                else
                {
                    throw new ArgumentException("Нужно было ввести число больше единицы", "numberOfPeople");
                }
            }
            else
            {
                throw new ArgumentException("Нужно было ввести число больше нуля", "numberOfPeople");
            }

            Console.ReadKey();
        }
    }
}
