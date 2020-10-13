using System;

namespace Event
{
    class Analog
    {
        public DateTime date ;
        public Analog()
        {
            
        }
        public void Show(Object obj, TimeEvent args)
        {
            Console.WriteLine("Analog Clocks : {0}:{1}:{2} ", args.Hour, args.Minute, args.Second);
        }
        public void Subscribe(Clocks clocks)
        {
            clocks.onSecondChange += new SecondChangeHandler(Show);
        }
    }
}
