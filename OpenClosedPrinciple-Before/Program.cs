using System;

namespace OpenClosedPrinciple_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer platinumCustomer = new Customer(CustomerType.Platinum);
            platinumCustomer.Sort();

            Customer goldCustomer = new Customer(CustomerType.Gold);
            goldCustomer.Sort();

            Customer silverCustomer = new Customer(CustomerType.Silver);
            silverCustomer.Sort();

            //new customer added
            Customer diamondCustomer = new Customer(CustomerType.Diamond);
            diamondCustomer.Sort();

            Console.ReadLine();
        }
    }
}
