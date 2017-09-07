using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInterface
{
    class TestClass : ITest1, ITest2
    {
        public object GetMenu()
        {
            return "TestClass";
        }
        object ITest1.GetMenu()
        {
            return "ITest1";
        }
        object ITest2.GetMenu()
        {
            return "ITest2";
        }
    }
}
