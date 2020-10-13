using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Clocks myClock = new Clocks();
            Analog c1 = new Analog();
            Digital c2 = new Digital();
            c1.Subscribe(myClock);
            c2.Subscribe(myClock);
            myClock.Run();
        }
    }
}
