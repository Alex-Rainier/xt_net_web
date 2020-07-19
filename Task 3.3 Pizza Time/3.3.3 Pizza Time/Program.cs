using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._3._3_Pizza_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер пиццы: ");

            Console.WriteLine("Маргарита = 1");
            Console.WriteLine("Маринара = 2");
            Console.WriteLine("Четыре Сезона = 3");
            Console.WriteLine("Карбонара = 4");
            Console.WriteLine("Пицца с Морепродуктами = 5");

            if(int.TryParse(Console.ReadLine(), out int choice))
            {
                var random = new Random();

                var order = random.Next(100);

                switch (choice)
                {
                    case 1:
                        var pizzaMargherita = new Margherita();
                        Console.WriteLine($"Ваш заказ номер - {order}, вы будете ждать свою пиццу примерно {pizzaMargherita.CookingTime} минут :)");
                        Thread.Sleep(pizzaMargherita.CookingTime * 1000);
                        Console.WriteLine($"Заказ номер - {order}, " + pizzaMargherita.PizzaIsReady());
                        break;
                    case 2:
                        var pizzaMarinara = new Marinara();
                        Console.WriteLine($"Ваш заказ номер - {order}, вы будете ждать свою пиццу примерно {pizzaMarinara.CookingTime} минут :)");
                        Thread.Sleep(pizzaMarinara.CookingTime * 1000);
                        Console.WriteLine($"Заказ номер - {order}, " + pizzaMarinara.PizzaIsReady());
                        break;
                    case 3:
                        var pizzaQuattroStagioni = new QuattroStagioni();
                        Console.WriteLine($"Ваш заказ номер - {order}, вы будете ждать свою пиццу примерно {pizzaQuattroStagioni.CookingTime} минут :)");
                        Thread.Sleep(pizzaQuattroStagioni.CookingTime * 1000);
                        Console.WriteLine($"Заказ номер - {order}, " + pizzaQuattroStagioni.PizzaIsReady());
                        break;
                    case 4:
                        var pizzaCarbonara = new Carbonara();
                        Console.WriteLine($"Ваш заказ номер - {order}, вы будете ждать свою пиццу примерно {pizzaCarbonara.CookingTime} минут :)");
                        Thread.Sleep(pizzaCarbonara.CookingTime * 1000);
                        Console.WriteLine($"Заказ номер - {order}, " + pizzaCarbonara.PizzaIsReady());
                        break;
                    case 5:
                        var pizzaFruttiDiMare = new FruttiDiMare();
                        Console.WriteLine($"Ваш заказ номер - {order}, вы будете ждать свою пиццу примерно {pizzaFruttiDiMare.CookingTime} минут :)");
                        Thread.Sleep(pizzaFruttiDiMare.CookingTime * 1000);
                        Console.WriteLine($"Заказ номер - {order}, " + pizzaFruttiDiMare.PizzaIsReady());
                        break;
                }
            }
            else
            {
                Console.WriteLine("Такой пиццы у нас нет :(");
            }

            Console.ReadKey();
        }
    }
}
