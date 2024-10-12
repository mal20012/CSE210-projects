using System;

public class Address{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool isUSA(){
        return _country == "USA" ? true : false;
    }
    public string GenerateAddress(){
        string address = _street + "," + _city + "\n" + _province + "," + _country;
        return address;
    }
}