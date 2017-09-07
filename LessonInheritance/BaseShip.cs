using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInheritance
{
    class BaseShip
    {
        private int _counter;

        protected int _speed;

        

        public BaseShip()
        {
            Console.WriteLine("Base");
        }

        public BaseShip(int _speed)
        {
            this._speed = _speed;
            Console.WriteLine("Base");
        }

        public virtual void Figth()
        {
            Console.WriteLine("Fight!!!");
        }

        public virtual string Move(int distance)
        {
            _counter++;

            string result = string.Format("Walked kilometers: {0}", distance);

            return result;
        }

        public override string ToString()
        {
            return "Base class to all ships";
        }
    }
}
