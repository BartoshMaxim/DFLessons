using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThreeWhales
{
    public static class StringHelper
    {
        public static int GetSymbolCount(this string text, char symbol)
        {
            char[] symbols = text.ToCharArray();

            int i = 0;
            foreach (char c in symbols)
                if (c == symbol) i++;
            return i;
        }
    }
}
