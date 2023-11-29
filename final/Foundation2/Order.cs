public class Order
{
    private List<Product> _products;

    private Customer _customer;


    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateCost()
    {
        double totalCost = 0;
        if (_customer.GetAddress().IsUsa())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice() * product.GetQuantity();
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductId()}: {product.GetName()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} {_customer.GetAddress().GetAddressString()}";
    }
}