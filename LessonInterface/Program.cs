using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();

            Console.WriteLine(test.GetMenu());

            ITest1 test1 = test;
            ITest2 test2 = test;
            Console.WriteLine(test1.GetMenu());
            Console.WriteLine(test2.GetMenu());
            Console.ReadKey(); 

            //Student student1 = new Student() { Age = 20, Name = "Alex" };
            //Student student2 = new Student() { Age = 18, Name = "Katua" };
            //Student[] arrayStudent = { student1, student2 };

            //Array.Sort(arrayStudent);
        }
    }
}
