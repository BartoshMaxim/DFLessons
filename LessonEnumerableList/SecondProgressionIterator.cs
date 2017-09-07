using System;
using System.Collections;
using System.Collections.Generic;

namespace LessonEnumerableList
{
    internal class SecondProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount;

        private int _position;
        private int _current;

        public SecondProgressionIterator(int itemCount)
        {
            _itemCount = itemCount;
            _current = 1;
            _position = 0;
        }

        public int Current
        {
            get
            {
                return Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return _current;
            }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (_position > 0)
                _current += 3;

            if (_position < _itemCount)
            {
                _position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _current = 1;
            _position = 0;
        }
    }
}