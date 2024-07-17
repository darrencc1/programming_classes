using System;


// Name, profuct id, price per unit, quantity of each product
// Total cost of product: price per unit * quantity.
class Product
{
    private string name;
    private string productId;
    private decimal pricePerUnit;
    private int quantity;
    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }
    public string Name
    {
        get { return name; }
    }
    public string ProductId
    {
        get { return productId; }
    }
    public decimal PricePerUnit
    {
        get { return pricePerUnit; }
    }
    public int Quantity
    {
        get { return quantity; }
    }
    public decimal TotalCost()
    {
        return pricePerUnit * quantity;
    }
}