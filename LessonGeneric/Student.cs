using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonGeneric
{
    public interface IStudent<out T>
    {
        T Move(int distance);

        void Fight(T input);
    }

    public interface IStudent1<in T>
    {
        T Move1(int distance);

        void Fight1(T input);
    }
    public class Student<T> : IStudent<T>, IStudent1<T>
    {
        public void Fight(T input)
        {
            throw new NotImplementedException();
        }

        public void Fight1(T input)
        {
            throw new NotImplementedException();
        }

        public T Move(int distance)
        {
            throw new NotImplementedException();
        }

        public T Move1(int distance)
        {
            throw new NotImplementedException();
        }
    }
}
