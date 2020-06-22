using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2_Game
{
    abstract class AbstractCharacter : AbstractObject
    {
        //Параметры персонажей
        string type;
        int hp;
        int mp;
        int damage;

        //Дейстия персонажей
        public abstract void Move();
        public abstract void MakeDamage();
        public abstract void TakeDamage();
        public abstract void RestoreHealth();
    }
}
