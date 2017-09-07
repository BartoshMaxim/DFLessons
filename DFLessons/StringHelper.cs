using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFLessons
{
    public delegate int CountDelgate(string s);
    class StringHelper
    {
        public int GetCount(string s)
        {
            return 0;
        }

        public int GetCountSymbolA(string s)
        {
            return 1;
        }

        public int GetCountSymbol(int i)
        {
            return 1;
        }
    }
}
