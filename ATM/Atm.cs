using System;

namespace ATM
{
    public delegate void onHandlerPhone(Object obj, Account eventArgs);
    class Atm
    {
        public event onHandlerPhone onChangeMoney;
        
        public void run()
        {
            while (true)
            {
                if(onChangeMoney != null)
                {

                    onChangeMoney(this, new Account());
                }
            }
        }
    }
}
