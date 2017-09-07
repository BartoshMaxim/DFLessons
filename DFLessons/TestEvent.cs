using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DFLessons
{
    public delegate void ShowMessage(string message);
    class TestEvent
    {
        //обычный делегат
        public Action<string> Method { get; set; }

        public event EventHandler<MovingEventArgs> DoIt;

        public void Move(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);
                if (DoIt != null)
                    DoIt(this, new MovingEventArgs(string.Format("Moving: {0}", i)));
            }
        }

    }
}
