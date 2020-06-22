using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_Custom_Paint
{
    public abstract class AbstractFigures
    {
        int x;

        protected int X
        {
            get => x;

            set
            {
                if (value > 0)
                    x = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        int y;

        protected int Y
        {
            get => y;

            set
            {
                if (value > 0)
                    y = value;
                else
                    throw new ArgumentOutOfRangeException("value", "Значение должно быть положительным!");
            }
        }

        protected AbstractFigures(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
