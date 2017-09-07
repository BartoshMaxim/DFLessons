using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonSealedStaticAbtract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseShip obj = new TransportShip();
        }

        static void TestMethod()
        {
            Singleton singleton = Singleton.Instance;

            Console.WriteLine(singleton.Count);
        }
    }
}
