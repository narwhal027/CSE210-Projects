using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> Products { get; }
        private Customer Customer { get; }

        public Order(List<Product> products, Customer customer)
        {
            Products = products;
            Customer = customer;
        }

        public double CalculateTotalPrice()
        {
            double productsTotal = Products.Sum(p => p.GetTotalCost());
            double shipping = Customer.IsInUSA() ? 5.0 : 35.0;
            return productsTotal + shipping;
        }

        public string GetPackingLabel()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Packing Label:");
            foreach (var p in Products)
            {
                sb.AppendLine($"- {p.Name} (ID: {p.ProductId})");
            }
            return sb.ToString().TrimEnd();
        }

        public string GetShippingLabel()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Shipping Label:");
            sb.AppendLine(Customer.GetName());
            sb.AppendLine(Customer.GetAddressString());
            return sb.ToString().TrimEnd();
        }
    }
}
