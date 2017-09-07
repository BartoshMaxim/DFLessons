using System;

namespace DFLessons
{
    internal class MovingEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public MovingEventArgs(string message)
        {
            Message = message;
        }
    }
}