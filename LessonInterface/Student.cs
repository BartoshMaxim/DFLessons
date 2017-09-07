using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInterface
{
    struct Student : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Student student = (Student)obj;
            if (this.Age > student.Age) return 1;
            if (this.Age > student.Age) return -1;

            return 0;
        }
    }
}
