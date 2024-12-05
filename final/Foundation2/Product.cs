using System.Runtime.InteropServices;

class Product
{
    // attributes
    private string _productName;

    private int _productID;

    private double _pricePerUnit;

    private int _quantity;

    // methods
    public Product(string productName, int productID, double pricePerUnit, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double CalcProductCost()
    {
        return _quantity * _pricePerUnit;
    }
}