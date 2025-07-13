namespace OnlineOrdering
{
    public class Product
    {
        public string Name { get; }
        public string ProductId { get; }
        public double UnitPrice { get; }
        public int Quantity { get; }

        public Product(string name, string productId, double unitPrice, int quantity)
        {
            Name = name;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public double GetTotalCost()
        {
            return UnitPrice * Quantity;
        }
    }
}
