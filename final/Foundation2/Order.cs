using System.Data.Common;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

class Order
{
    // attributes
    private Customer _customer;

    private List<Product> _products = new();


    // methods
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double CalcCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.CalcProductCost();
        }
        if (_customer.isDomestic())
            total += 5;
        else
            total += 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductID(),-10}{product.GetProductName(),-15}  x{product.GetQuantity()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

    public void NewProduct(string name, int id, double pricePerUnit, int quantity)
    {
        Product newProduct = new(name, id, pricePerUnit, quantity);
        _products.Add(newProduct);
    }
}