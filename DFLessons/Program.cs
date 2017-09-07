using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Program objProgram = new Program();
            TestEvent testEvent = new TestEvent();
            testEvent.DoIt += moving;
            int distance = 100;

            testEvent.Move(distance);
        }

        private static void moving(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        void ShowInConsole(string message)
        {
            Console.WriteLine(message);
        } 
       
    }
}
