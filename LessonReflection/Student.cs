using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonReflection
{
    public class Student
    {
        private int _temp = 7;

        public string Name { get; set; }

        [MySimpleAttribure(Number = 5)]
        public string Age { get; set; }
    }
}
