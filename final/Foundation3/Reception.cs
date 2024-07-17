using System;
class Reception : Event
{
    private string email;
    public Reception(string title, string description, string date, string time, Address address, string email): base(title, description, date, time, address)
    {
        this.email = email;
    }
    public override string FullDetails()
    {
        return StandardDetails() + $"Type: Reception\n Email: {email}\n";
    }
}