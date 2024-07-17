using System;

// string street address, city, state/province, and country
// Method for if in USA or Not
// Method to return a string of all of its fields together in one string. (new line characters where appropriate. )
class Address
{
    private string street;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string street, string city, string stateProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{street}\n{city}, {stateProvince}, {country}";
    }
}