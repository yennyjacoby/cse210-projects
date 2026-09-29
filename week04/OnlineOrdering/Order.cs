using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
    
    //Constructor
    public Order (Customer customer)
    {
        _customer= customer;
        _products= new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CostPerProduct();
        }

        if ( _customer.LiveInUsa())
        {
            totalCost += 5;
        }
        else 
        {
            totalCost +=35;
        }

        
        return totalCost;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().FullAddress()}";
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetProductName()} - {product.GetProductId()}\n";
        }
        return label; 
    }


}