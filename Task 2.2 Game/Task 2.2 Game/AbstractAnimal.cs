using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2_Game
{
    class AbstractAnimal : AbstractEnemy
    {
        //А от абстрактного животного уже пойдут конкретные
        public override void Move() { }
        public override void MakeDamage() { }
        public override void TakeDamage() { }
        public override void RestoreHealth() { }
    }
}
