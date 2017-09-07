using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInheritance
{
    class FightShip : BaseShip
    {
        public override string Move(int distance)
        {
            return base.Move(distance);
        }

        public override void Figth()
        {
            Console.WriteLine("The enemy is destroyed!!");
        }
    }
}
