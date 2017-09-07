using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonLINQ
{
    public static class LinqHelper
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return new WhereHelperEnumerable<T>(source,predicate);
        }
    }
}
