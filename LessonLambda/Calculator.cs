using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonLambda
{
    public delegate int ArifmeticOperation(int x, int y);
    class Calculator
    {
        public Func<int, int, int> PlusFunction()
        {
            Func<int, int, int> func = (x, y) => x + y;
            return func;
        }

        public Func<int, int, int> MinusFunction()
        {
            Func<int, int, int> func = ( x, y) =>  x - y; ;
            return func;
        }
    }
}
