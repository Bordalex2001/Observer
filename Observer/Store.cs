using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    public interface IClerk
    {
        void Attach(ICustomer customer);
        void Detach(ICustomer customer);
        void Notify();
    }
    public class Store : IClerk
    {
        public int state { get; set; } = 0;
        private List<ICustomer> _customers = new List<ICustomer>();
        public void Attach(ICustomer customer)
        {
            Console.WriteLine("Customer was attached.");
            this._customers.Add(customer);
        }
        public void Detach(ICustomer customer)
        {
            Console.WriteLine("Customer was detached.");
            this._customers.Remove(customer);
        }
        public void Notify()
        {
            Console.WriteLine("Store is notifying customers...");
            foreach(var customer in _customers)
            {
                customer.Update(this);
            }
        }
        public void StoreLogic()
        {
            Console.WriteLine("Clerk is enabling notifications.");
            this.state = new Random().Next(0, 12);
            Thread.Sleep(30);
            Console.WriteLine("The state has changed to " + this.state);
            this.Notify();
        }
    }
}
