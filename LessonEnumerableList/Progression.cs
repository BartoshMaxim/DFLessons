using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEnumerableList
{
    class Progression : IEnumerable<int>
    {
        private readonly int _itemCount;

        public Progression(int itemCount)
        {
            _itemCount = itemCount;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int current = 1;
            for(int i = 0; i < _itemCount - 1; i++)
            {
                if (i == 0) yield return 1;

                current+=3;
                yield return current;


            }
            //return new ProgressionIterator(_itemCount);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
