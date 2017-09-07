using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInterface
{
    public class TransportShip : IShip, IDestroyable
    {
        public string Destroy()
        {
            return "Transportship destroyed";
        }

        public string Fight()
        {
            return "Transportship can not fight";
        }

        public string Move(int distance)
        {
            double time = (double)distance / 1000;
            string resurt = string.Format("Kilometers passed: {0} for {1} hours",distance,time);
            return resurt;
        }
    }
}
