using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEnumerableList
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression progression = new Progression(100);
            foreach (int i in progression)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
