using System;

namespace LiskovSubstitution
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

            Console.ReadLine();
        }
    }
}
