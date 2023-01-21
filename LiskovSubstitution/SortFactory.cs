namespace LiskovSubstitution
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

            return null;
        }
    }
}
