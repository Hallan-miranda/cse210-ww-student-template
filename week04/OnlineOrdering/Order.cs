using System;

class Order
{
    private List<Product> _products;
        private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetproductPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }

        return total;
    }
    public double GetTax()
    {
        double tax = 0;
        if (_customer.isUsa())
        {
            tax += 5.00; 
        }
        else
        {
            tax += 10.00; 
        }
        return tax;
    }

    public double GetTotalPrice()
    {
        return GetproductPrice() + GetTax();
    }

}