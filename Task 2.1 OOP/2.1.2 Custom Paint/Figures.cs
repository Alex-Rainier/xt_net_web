using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_Custom_Paint
{
    #region Circle
    public class Circle : AbstractFigures
    {
        double innerRadius;
        public double InnerRadius
        {
            get => innerRadius;

            set
            {
                if (value > 0)
                    innerRadius = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        public double InnerPerimeter { get; set; }

        public Circle(int x, int y, double innerRadius) : base(x, y)
        {
            this.innerRadius = innerRadius;
        }

        public virtual void FindInnerPerimeter()
        {
            InnerPerimeter = 2 * Math.PI * innerRadius;
        }

        public override string ToString()
        {
            FindInnerPerimeter();
            return "Окружность создана! \n" + "Радиус: " + InnerRadius + "\n" + "Периметр: " + InnerPerimeter + "\n" +
                "Координаты начальной точки: " + X + " " + Y;
        }
    }
    #endregion

    #region Ring
    public class Ring : Circle
    {
        double outRadius;
        public double OutRagius
        {
            get => outRadius;

            set
            {
                if (value > 0)
                    outRadius = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        public double OutPerimetr { get; set; }

        public double Area { get; set; }

        public Ring(int x, int y, double innerRadius, double outRadius) : base(x, y, innerRadius)
        {
            this.outRadius = outRadius;
        }

        public virtual void FindOutPerimetr()
        {
            OutPerimetr = 2 * Math.PI * outRadius;
        }

        public void FindArea()
        {
            Area = Math.PI * ((outRadius * outRadius) - (InnerRadius * InnerRadius));
        }

        public override string ToString()
        {
            FindInnerPerimeter();
            FindArea();

            return "Кольцо создано! \n" + "Внешний радиус: " + outRadius + "\n" + "Внутренний радиус: " + InnerRadius + "\n" +
                        "Площадь в метрах квадратных: " + Area + "\n" + "Координаты точки начала: " + X + " " + Y;
        }
    }
    #endregion

    #region Round
    public class Round : Circle
    {
        double innerAreaRound;
        protected double InnerArea
        {
            get => innerAreaRound;

            set
            {
                if (value > 0)
                    innerAreaRound = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        public Round(int x, int y, double innerRadius) : base(x, y, innerRadius)
        {
            InnerRadius = innerRadius;
        }

        public void FindArea()
        {
            innerAreaRound = InnerRadius * Math.PI * InnerRadius;
        }

        public override string ToString()
        {
            FindArea();

            return "Круг создан! \n" + "Радиус: " + InnerRadius + "\n" +
                        "Площадь в метрах квадратных: " + innerAreaRound + "\n" + "Координаты точки начала: " + X + " " + Y;
        }
    }
    #endregion

    #region Rectangle
    public class Rectangle : AbstractFigures
    {
        int area { get; set; }
        int perimeter { get; set; }

        int sideA;

        public int SideA
        {
            get => sideA;

            set
            {
                if (value > 0)
                    sideA = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        private int sideB;
        public int SideB
        {
            get => sideB;

            set
            {
                if (value > 0)
                    sideB = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        public Rectangle(int x, int y, int sideA, int sideB) : base(x, y)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public void FindArea()
        {
            area = SideA * SideB;
        }

        public void FindPerimetr()
        {
            perimeter = (SideB + SideA) * 2;
        }

        public override string ToString()
        {
            FindArea();
            FindPerimetr();
            return "Прямоугольник создан! \n" + "Площадь в метрах квадратных: " + area + "\n" + "Периметр: " + perimeter + "\n" +
                        "Координаты начальной точки: " + X + " " + Y;
        }
    }
    #endregion

    #region Square
    public class Square : AbstractFigures
    {
        int sideSquare;
        public int SideSquare
        {
            get => sideSquare;

            set
            {
                if (value > 0)
                    sideSquare = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        public int Perimeter { get; set; }

        public int Area { get; set; }

        public Square(int x, int y, int sideSquare) : base(x, y)
        {
            this.sideSquare = sideSquare;
        }

        public void FindPerimeter()
        {
            Perimeter = sideSquare * 4;
        }

        public void FindArea()
        {
            Area = sideSquare * sideSquare;
        }

        public override string ToString()
        {
            FindArea();
            FindPerimeter();

            return "Квадрат создан! \n" + "Площадь в метрах квадратных: " + Area + "\n" + "Периметр: " + Perimeter + "\n" + 
                        "Координаты точки начала: " + X + " " + Y;
        }
    }
    #endregion

    #region Triangle
    public class Triangle : AbstractFigures
    {
        int area { get; set; }
        int perimeter { get; set; }

        int sideA;
        public int SideA
        {
            get => sideA;

            set
            {
                if (value > 0)
                    sideA = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        int sideB;
        public int SideB
        {
            get => sideB;

            set
            {
                if (value > 0)
                    sideB = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        int sideC;
        public int SideC
        {
            get => sideC;

            set
            {
                if (value > 0)
                    sideC = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        public Triangle(int x, int y, int sideA, int sideB, int sideC) : base(x, y)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public void FindArea()
        {
            area = (int)Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
        }

        public void FindPerimeter()
        {
            perimeter = sideA + sideB + sideC;
        }

        public override string ToString()
        {
            FindArea();
            FindPerimeter();
            return "Треугольник создан! \n" + "Площадь в метрах квадратных: " + area + "\n" + "Периметр: " + perimeter + "\n" +
                        "Координаты точки начала: " + X + " " + Y;
        }
    }
    #endregion

    #region Line
    public class Line : AbstractFigures
    {
        int length;
        public int Length
        {
            get => length;

            set
            {
                if (value > 0)
                    length = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        public Line(int x, int y, int length) : base(x, y)
        {
            this.length = length;
        }

        public override string ToString()
        {
            return "Линия создана! \n" + "Длинна: " + length + "\n" + "Координаты точки начала: " + X + " " + Y;
        }
    }
    #endregion
}
