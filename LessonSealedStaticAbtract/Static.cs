using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonSealedStaticAbtract
{
    class TestClass
    {
        public TestClass()
        {
            Console.WriteLine("TestClass");
        }
    }

    //статические классы не потдерживают наследование
    class Student : TestClass
    {
        public Student()
        {
            Console.WriteLine("Student");
        }

        static Student()
        {
            Console.WriteLine("Static Static");
        }
    }
}
