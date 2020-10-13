using System;

namespace ATM
{
    public class Account : EventArgs
    {
        public int iD { get; set; }
        public string name { get; set; }

        public double money { get; set; }

        public int telephone { get; set; }
    }
}
