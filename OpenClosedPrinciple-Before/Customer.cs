namespace OpenClosedPrinciple_Before
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
            if (this.Type == CustomerType.Platinum)
            {
                var sort = new BubbleSort();
                sort.Sort();
            }


            else if (this.Type == CustomerType.Gold)
            {
                var sort = new QuickSort();
                sort.Sort();
            }

            else if (this.Type == CustomerType.Silver)
            {
                var sort = new HeapSort();
                sort.Sort();
            }

            // new sort added- modified existing class- violated open closed principle
            else if (this.Type == CustomerType.Diamond)
            {
                var sort = new DiamondSort();
                sort.Sort();
            }
        }


    }
}
