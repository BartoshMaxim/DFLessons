using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseShip ship = getShip(ShipType.FightShip);
            ship.Figth();
            

            Console.ReadKey();
        }

        static BaseShip getShip(ShipType type)
        {
            switch (type)
            {
                case ShipType.FightShip:
                    return new FightShip();
                case ShipType.TransportShip:
                    return new TransportShip();
                default:
                    throw new Exception();
            }
        }
    }
}
