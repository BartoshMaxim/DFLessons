using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LessonLINQ
{
    class Program
    {
       
        static void Main(string[] args)
        {
            TestSet set = new TestSet();
            var filteredSet = set.Where(s => s % 2 == 0);

            foreach(int i in filteredSet)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
