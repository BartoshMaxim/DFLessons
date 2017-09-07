using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonSealedStaticAbtract
{
    abstract class BaseShip
    {
        public virtual string Move(int distance)
        {
            string result = string.Format("Kilometers passed {0}", distance);
            return result;
        }

        public virtual string Fight()
        {
            string result = string.Format("Fight");
            return result;
        }

        public abstract void Land(int x, int y);
    }
}
