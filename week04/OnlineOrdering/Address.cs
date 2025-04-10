using System;

class Address
{
    private string _street;
    private string _city;
    private string _stateOrprovince;
    private string _country;

    public Address(string street, string city, string stateOrprovince, string country)
    {
        _street = street;
        _city = city;
        _stateOrprovince = stateOrprovince;
        _country = country;

    }



    public bool isUsa()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_stateOrprovince}, {_country}";
    }
}