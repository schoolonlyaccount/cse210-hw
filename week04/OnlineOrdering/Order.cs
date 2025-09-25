using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product) => _products.Add(product);
    public double GetTotalOrderCost()
    {
        double orderTotal = 0;
        foreach (Product p in _products)
        {
            orderTotal += p.GetTotalProductCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return orderTotal + shippingCost;
    }
    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (Product p in _products)
        {
            sb.AppendLine($"{p.GetName()} (ID: {p.GetId()})");
        }
        return sb.ToString();
    }
    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Shipping Label:");
        sb.AppendLine(_customer.GetName());
        sb.AppendLine(_customer.GetFullAddress());
        return sb.ToString();
    }
}