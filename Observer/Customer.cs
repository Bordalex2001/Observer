using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Observer
{
    public interface ICustomer
    {
        void Update(IClerk clerk);
    }
    class CustomerA : ICustomer
    {
        public void Update(IClerk clerk)
        {
            if((clerk as Store).state < 6)
            {
                Console.WriteLine("Customer A has read the notification.");
            }
        }

    }
    class CustomerB : ICustomer
    {
        public void Update(IClerk clerk)
        {
            if((clerk as Store).state >= 5)
            {
                Console.WriteLine("Customer B has read the notification.");
            }
        }
    }
    class CustomerC : ICustomer
    {
        public void Update(IClerk clerk)
        {
            if((clerk as Store).state >= 4)
            {
                Console.WriteLine("Customer C has read the notification.");
            }
        }
    }
    class CustomerD : ICustomer
    {
        public void Update(IClerk clerk)
        {
            if((clerk as Store).state == 0 || (clerk as Store).state <= 3)
            {
                Console.WriteLine("Customer D has read the notification.");
            }
        }
    }
}
