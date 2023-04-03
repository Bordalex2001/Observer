using System;

namespace Observer
{
    internal class Program
    {
        static void Main()
        {
            Store clerk = new Store();
            
            CustomerA customerA = new CustomerA();
            clerk.Attach(customerA);
            Console.Write("\n");

            clerk.StoreLogic();
            Console.Write("\n");

            CustomerB customerB = new CustomerB();
            clerk.Attach(customerB);
            Console.Write("\n");

            clerk.StoreLogic();
            Console.Write("\n");

            clerk.Detach(customerA);
            Console.Write("\n");

            CustomerC customerC = new CustomerC();
            clerk.Attach(customerC);
            Console.Write("\n");

            clerk.StoreLogic();
            Console.Write("\n");

            CustomerD customerD = new CustomerD();
            clerk.Attach(customerD);
            Console.Write("\n");

            clerk.Detach(customerB);
            Console.Write("\n");

            clerk.StoreLogic();
            Console.Write("\n");
        }
    }
}
