using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Cat();
            IStudent<Animal> student = new Student<Animal>();//инвариантная
            //не потдерживают классы ковариантность контрвариантность
            IStudent<Animal> student2 = new Student<Cat>();//ковариантная
            IStudent1<Animal> student2 = new Student<Cat>();//контрвариантный интерфейс
        }

        static void NonGenericList()
        {
            ArrayList list = new ArrayList() { 1, 2, 3 };

            list.Add(4);
            list.Add("5");
            int sum = 0;
            foreach (var element in list)
            {
                sum += (int)element;
            }
            Console.WriteLine(sum);
        }

        static void GenericList()
        {
           List<int> list = new List<int>() { 1, 2, 3 };

            list.Add(4);
            int sum = 0;
            foreach (var element in list)
            {
                sum += element;
            }
            Console.WriteLine(sum);
        }
    }
}
