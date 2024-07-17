using System;

// Name and Address
// name is string, Address is a !CLASS!
// Method if they live in USA or not (Call a methdon the address to find this. )
class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name
    {
        get { return name; }
    }

    public Address Address
    {
        get { return address; }
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}