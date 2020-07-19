using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3_Pizza_Time
{
    class Margherita : AbstractPizza
    {
        public override int CookingTime { get; } = 10;

        public override string PizzaIsReady()
        {
            return "Ваша пицца Маргарита готова!";
        }
    }

    class Marinara : AbstractPizza
    {
        public override int CookingTime { get; } = 12;

        public override string PizzaIsReady()
        {
            return "Ваша пицца Маринара готова!";
        }
    }

    class QuattroStagioni : AbstractPizza
    {
        public override int CookingTime { get; } = 15;

        public override string PizzaIsReady()
        {
            return "Ваша пицца Четыре Сезона готова!";
        }
    }

    class Carbonara : AbstractPizza
    {
        public override int CookingTime { get; } = 15;

        public override string PizzaIsReady()
        {
            return "Ваша пицца Карбонара готова!";
        }
    }

    class FruttiDiMare : AbstractPizza
    {
        public override int CookingTime { get; } = 15;

        public override string PizzaIsReady()
        {
            return "Ваша Пицца с Морепродуктами готова!";
        }
    }
}
