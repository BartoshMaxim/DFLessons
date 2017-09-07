using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonGeneric
{
    class Zoo<T>
        where T : Animal, new ()
    {
        public void MoveAnimal(T animal)
        {
            animal.Move();
        }

        public T GetNewAnimal()
        {
            T animal = new T();
            return animal;
        }
    }
}
