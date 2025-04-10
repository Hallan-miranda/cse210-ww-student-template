using System;
using System.Collections.Specialized;

class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public String GetCustomer()
    {
        return $" {_name} \n {_address.GetFullAddress()}";
    }
    public bool isUsa()
    {
        return _address.isUsa();
    }
}