using System;

public class Product
{
    private string _productName;
    private string _productId;
    // double because it means DECIMALS
    private double _price;
    private int _quantity;


//Since my fields are private I need to create CONSTRUCTOR

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CostPerProduct()
    {
        return _price* _quantity;
    }    

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }
}