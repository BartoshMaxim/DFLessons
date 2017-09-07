using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LessonEnumerableList
{
    class StoreCollection : ICollection<int>
    {
        private readonly string _filename;

        public StoreCollection(string filename)
        {
            _filename = filename;
        }

        private string[] GetNumbers()
        {
            string content = File.ReadAllText(_filename);
            string[] mass = content.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            return mass;
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(int item)
        {
            string[] numbers = GetNumbers();

            if (numbers.Length == 0)
                File.WriteAllText(_filename, item.ToString());
            else
                File.AppendAllText(_filename, ";" + item.ToString());
        }

        public void Clear()
        {
            File.WriteAllText(_filename, "");
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            string[] mass = GetNumbers();

            foreach (string number in mass)
            {
                yield return int.Parse(number);
            }
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
