using System;
using System.Threading;

namespace Event
{
    public delegate void SecondChangeHandler(Object clock, TimeEvent info);
    public class Clocks
    {
        public  event SecondChangeHandler onSecondChange;
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if(onSecondChange != null)
                {
                    DateTime date = DateTime.Now;
                    onSecondChange(this, new TimeEvent(date.Hour,date.Minute,date.Second));
                }
            }
        }
    }
}
