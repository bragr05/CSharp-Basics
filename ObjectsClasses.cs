// Forms of creating objects
Product computer = new Product("HP Victus", 500.0m);

var phone = new Product("Samsung S24 Ultra", 999.0m);

// This form is used when there is no constructor or there is one that does not expect parameters.
var headset = new Product
{
    ProductName = "Razer",
    ProductPrice = 80.0m
};


public class Product
{

    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }

    public Product(string name, decimal price)
    {
        ProductName = name;
        ProductPrice = price;
    }

    public Product()
    {
    }

}