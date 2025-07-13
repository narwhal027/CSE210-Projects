namespace OnlineOrdering
{
    public class Customer
    {
        private string Name { get; }
        private Address Address { get; }

        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public bool IsInUSA()
        {
            return Address.IsInUSA();
        }

        public string GetName() => Name;

        public string GetAddressString() => Address.GetFormattedAddress();
    }
}
