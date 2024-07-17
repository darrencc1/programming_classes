using System;
// Standard Details: title, description, date, time, address
// Short Details: List type of event, title, date
// Full Details: standard details, information specific for the event.
abstract class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;
    // Use protected not private so that I can use base(Call constructor of the base class from WITHIN derived class constructor)
    protected Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.time = time;
        this.address = address;
        this.date = date;
    }
    public string StandardDetails()
    {
        return $"Title: {title} Description: {description}\n Date: {date} Time: {time}\n Address: {address}\n";
    }
    public string ShortDetails()
    {
        return $"Type: {GetType().Name}\nTitle: {title}\n Date: {date}";
    }
    public abstract string FullDetails();
}