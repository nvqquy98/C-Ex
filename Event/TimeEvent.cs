using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class TimeEvent : EventArgs
    {
        public readonly int Second;
        public readonly int Hour;
        public readonly int Minute;
        public TimeEvent(int h , int m , int s)
        {
            Second = s;
            Hour = h;
            Minute = m;
        }
    }
}
