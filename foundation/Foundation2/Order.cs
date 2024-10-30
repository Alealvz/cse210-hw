using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public List<Product> Products
    {
        get { return _products; }
        set { _products = value; }
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in _products)
        {
            label.AppendLine(product.ToString());
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return _customer.ToString();
    }
}