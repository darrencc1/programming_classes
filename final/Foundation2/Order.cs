using System;
// List of products and a customer
// Calculate Total Cost of the order
// Return string for packing label and shipping label
// packing label: List name and product id of each prouct in the order
// shipping label: list name and address of the customer
// Total price calculated as sum of total cost of each product +one-time shipping cost
// shipping-cost: USA 5$, not USA:35$
class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }
        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address}";
    }
}
