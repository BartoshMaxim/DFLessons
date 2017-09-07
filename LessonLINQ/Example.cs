using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonLINQ
{
    class Example
    {
        public static void Where()
        {
            TestSet set = new TestSet();

            var filteredSet = set.Where(s => s > 50);
            foreach (int i in filteredSet)
            {
                Console.WriteLine(i);
            }
        }
        public static void Select()
        {
            TestSet set = new TestSet();
            var filteredSet2 = set.Select(s => new { Age = "age -- " + s.ToString() });
            foreach (var i in filteredSet2)
            {
                Console.WriteLine(i.Age);
            }
        }
        public static void WhereSelect()
        {
            TestSet set = new TestSet();
            var filteredSet3 = set.Where(s => s > 50).Select(s => new { Age = "new age -- " + s.ToString() });
            foreach (var i in filteredSet3)
            {
                Console.WriteLine(i.Age);
            }
        }
        //Тоже самое, что и First, FirstOrDefault, SingleOrDefault
        public static void Single()
        {
            TestSet set = new TestSet();
            var filteredSet4 = set.Single(s => s % 57 == 0);
            Console.WriteLine("Single--" + filteredSet4);
        }
        public static void Aggregate()
        {
            TestSet set = new TestSet();
            var filteredSet5 = set.Where(i => i <= 5).Aggregate(1, (acc, s) => acc * s);
            Console.WriteLine("Aggregate-- " + filteredSet5);
        }

        public static void OrderBy()
        {
            TestSet set = new TestSet();
            var filteredSet6 = set.Select(s => new { Number = s, IsEven = s % 2 == 0 }).OrderBy(s => !s.IsEven);
            foreach (var i in filteredSet6)
            {
                Console.WriteLine(i);
            }
        }

        public static void Hard()
        {
            TestSet set = new TestSet();
            var filteredSet7 = set.Where(s => s % 2 == 0)
                .Select(s => "*" + s.ToString() + "s")
                .Where(s => s.Length == 4);
            foreach (string i in filteredSet7)
            {
                Console.WriteLine(i);
            }
        }
    }
}
