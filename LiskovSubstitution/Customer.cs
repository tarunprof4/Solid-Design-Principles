namespace LiskovSubstitution
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
            var sortFactory = new SortFactory();
            var sort = sortFactory.Create(this);

            // code smell
            if(sort is HeapSort)
            {
                return;
            }
            sort.Sort();
        }
    }
}
