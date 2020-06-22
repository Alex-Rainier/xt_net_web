using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_Custom_Paint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] param;

            List<AbstractFigures> relult = new List<AbstractFigures>();

            while (true)
            {
                Console.WriteLine("Пожалуйста, выберите действие: ");
                Console.WriteLine("1. Добавить фигуру");
                Console.WriteLine("2. Показать фигуры");
                Console.WriteLine("3. Очистить");
                Console.WriteLine("4. Выйти");

                int.TryParse(Console.ReadLine(), out int selectAction);

                switch (selectAction)
                {
                    case 1:

                        Console.WriteLine("Пожалуйста, выберите тип фигуры и ведите соответствующее ей число");
                        Console.WriteLine("1. Кольцо");
                        Console.WriteLine("2. Окружность");
                        Console.WriteLine("3. Круг");
                        Console.WriteLine("4. Квадрат");
                        Console.WriteLine("5. Прямоугольние");
                        Console.WriteLine("6. Линия");
                        Console.WriteLine("7. Треугольник");

                        int.TryParse(Console.ReadLine(), out int selectFigure);

                        switch (selectFigure)
                        {
                            case 1:
                                param = new int[4];
                                Console.WriteLine("Введите две координаты начала, внешний и внутренний радиус: ");
                                break;
                            case 2:
                                param = new int[3];
                                Console.WriteLine("Введите две координаты начала и внутренний радиус: ");
                                break;
                            case 3:
                                param = new int[3];
                                Console.WriteLine("Введите две координаты начала и внутренний радиус: ");
                                break;
                            case 4:
                                param = new int[3];
                                Console.WriteLine("Введите две координаты начала и одну сторону: ");
                                break;
                            case 5:
                                param = new int[4];
                                Console.WriteLine("Введите две координаты начала, сторону А и сторону В: ");
                                break;
                            case 6:
                                param = new int[3];
                                Console.WriteLine("Введите две координаты начала и длинну: ");
                                break;
                            case 7:
                                param = new int[5];
                                Console.WriteLine("Введите две координаты начала, сторону А, сторону В и сторону С: ");
                                break;
                            default:
                                param = new int[0];
                                break;
                        }

                        for (int i = 0; i < param.Length; i++)
                        {
                            int.TryParse(Console.ReadLine(), out int x);

                            if (x <= 0 || string.IsNullOrWhiteSpace(x.ToString()))
                            {
                                selectFigure = 8;
                            }
                            param[i] = x;
                        }

                        switch (selectFigure)
                        {
                            case 1:
                                relult.Add(new Ring(param[0], param[1], param[2], param[3]));
                                break;
                            case 2:
                                relult.Add(new Circle(param[0], param[1], param[2]));
                                break;
                            case 3:
                                relult.Add(new Round(param[0], param[1], param[2]));
                                break;
                            case 4:
                                relult.Add(new Square(param[0], param[1], param[2]));
                                break;
                            case 5:
                                relult.Add(new Rectangle(param[0], param[1], param[2], param[3]));
                                break;
                            case 6:
                                relult.Add(new Line(param[0], param[1], param[2]));
                                break;
                            case 7:
                                relult.Add(new Triangle(param[0], param[1], param[2], param[3], param[4]));
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < relult.Count; i++)
                        {
                            Console.WriteLine(relult[i].ToString());
                        }
                        break;
                    case 3:
                        relult.Clear();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
