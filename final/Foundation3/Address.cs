namespace EventPlanning
{
    public class Address
    {
        private string Street { get; }
        private string City { get; }
        private string StateOrProvince { get; }
        private string Country { get; }

        public Address(string street, string city, string stateOrProvince, string country)
        {
            Street = street;
            City = city;
            StateOrProvince = stateOrProvince;
            Country = country;
        }

        public string GetFormattedAddress()
        {
            return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
        }
    }
}
