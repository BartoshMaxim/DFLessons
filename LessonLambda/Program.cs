using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonLambda
{

    class Program
    {
        public event EventHandler<EventArgs> DoIt;

        static void Main(string[] args)
        {
            var program = new Program();
            program.DoIt += delegate { Console.WriteLine("TEST"); };
            program.DoIt(program, EventArgs.Empty);

            Calculator calc = new Calculator();
            //----------------------------------
            Func<int, int, int> func = (x, y) => x + y;
            int result = func(1, 2);
            Console.WriteLine(result);
            Func<int, Func<int, int, int>, int> func2 = (x, y) => y(2, 5) * x;
            int result2 = func2(2,func);
            Console.WriteLine(result2);
            //----------------------------------
            Func<int, int> fc = null;
            fc = i =>
            {
                Console.WriteLine(i);
                return i == 0 ? 0 : fc(--i);
            };
            fc(10);
            //----------------------------------
            Action action = null;
            for(int cycleCounter=1; cycleCounter<=4; cycleCounter++)
            {
                int buffer = cycleCounter;
                action += () => Console.WriteLine(buffer);
                
            }
            action();
            Console.ReadKey();
        }
    }
}
