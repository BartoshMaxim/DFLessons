using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInheritance
{
    //sealed  - нельзя наследоваться
    sealed class TransportShip : BaseShip
    {
        public TransportShip()
            : base(0)
        {
            Console.WriteLine("Childrer");
        }

        public override string Move(int distance)
        {
            string result = base.Move(distance);
            result += string.Format("Transport ship walked kilometers: {0}", distance);

            return result;
        }

        public override void Figth()
        {
            Console.WriteLine("Transport ship can not fight");
        }

        public override string ToString()
        {
            return "Base class to all transport ships";
        }
        public void Show()
        {

        }
    }
}
