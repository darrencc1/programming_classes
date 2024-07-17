using System;
using System.ComponentModel;
using System.Reflection;
// detail include Weather for day of event. 
class Outdoor : Event
{
    private string weather;
    public Outdoor(string title, string description, string date, string time, Address address, string weather): base(title, description, date, time, address)
    {
        this.weather = weather;
    }
    public override string FullDetails()
    {
        return StandardDetails() + $"Type: Outdoor Event\n Weather Forecast: {weather}\n";
    }
}