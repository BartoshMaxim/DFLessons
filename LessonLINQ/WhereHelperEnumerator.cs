using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonLINQ
{
    public class WhereHelperEnumerator<T> : IEnumerator<T>
    {
        private readonly IEnumerator<T> _sourceEnumerator;
        private readonly Func<T, bool> _predicate;

        public T Current
        {
            get
            {
                return _sourceEnumerator.Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public WhereHelperEnumerator(IEnumerator<T> source, Func<T, bool> predicate)
        {
            _sourceEnumerator = source;
            _predicate = predicate;

        }

        public void Dispose()
        {
            _sourceEnumerator.Dispose();
        }

        public bool MoveNext()
        {
            bool isValid = false;
            while (_sourceEnumerator.MoveNext())
            {
                T current = _sourceEnumerator.Current;
                isValid = _predicate(current);

                if (isValid) break;
            }
            return isValid;
        }

        public void Reset()
        {
            _sourceEnumerator.Reset();
        }
    }
}
