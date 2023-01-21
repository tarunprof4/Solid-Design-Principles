using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class SortFactory
    {
        public ISort Create(Customer customer)
        {
            if (customer.Type == CustomerType.Platinum)
                return new BubbleSort();

            else if (customer.Type == CustomerType.Gold)
                return new QuickSort();

            else if (customer.Type == CustomerType.Silver)
                return new HeapSort();

            //sorting factory modified - but this is not violation of open closed principle as the entire logic to modify
            //sits in one class for customer.cs and similar future classes as we will create multiple create methods
            else if (customer.Type == CustomerType.Diamond)
                return new DiamondSort();

            return null;
        }
    }
}
