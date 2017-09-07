using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonSealedStaticAbtract
{
    class TransportShip : BaseShip
    {
        public override string Move(int distance)
        {
            string result = string.Format("transport ship kilometers passed {0}", distance);
            return result;
        }

        public override string Fight()
        {
            string result = string.Format("Cant fight");
            return result;
        }

        public override void Land(int x, int y)
        {
            Console.WriteLine("Ship landed");
        }
    }
}
