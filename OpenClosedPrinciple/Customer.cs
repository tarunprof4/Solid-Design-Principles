using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class Customer
    {
        public Customer(CustomerType type)
        {
            this.Type = type;
        }
        public CustomerType Type { get; }
        public void Sort()
        {
            // new sort added- no change in existing class- abided open closed principle
            var sortFactory = new SortFactory();
            var sort = sortFactory.Create(this);
            sort.Sort();
        }
    }
}
