using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonReflection
{
    [AttributeUsage(AttributeTargets.Property)]
    class MySimpleAttribure : Attribute
    {
        public int Number { get; set; }
    }
}
