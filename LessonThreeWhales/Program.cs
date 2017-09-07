using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThreeWhales
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = "text";
            int count = text.GetSymbolCount('t');
            Console.WriteLine(count);
            Console.ReadKey();

            List<int> lst = new List<int>();

            var a = new { Name = "Bob", Age = 1 };
            var arr = new[] { a };
            var result = arr.ToList();
            result.Clear();
        }
    }
}
