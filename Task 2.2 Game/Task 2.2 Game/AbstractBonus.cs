using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2_Game
{
    abstract class AbstractBonus : AbstractObject
    {
        string type;

        public abstract void Effect();
    }
}
