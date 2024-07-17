using System;
public class Program
{
    public static void Main()
    {
        Address address1 = new Address("175 W Albania st", "Warrenton", "VA", "62701");
        Address address2 = new Address("456 Wanabe St", "Warrenton", "VA", "62701");
        Address address3 = new Address("789 Oak St", "Richmmond", "VA", "83475");

        Event lecture = new Lecture("LSTMs and How we have Surpased them", "A talk about the latest in Recurrent Models", "2024-07-22", "10:00 AM", address1, "Darren Chambers", 250);
        Event reception = new Reception("Company Meet and Greet", "Network with industry professionals.", "2024-08-02", "6:00 PM", address2, "rsvp@company.com");
        Event outdoor = new Outdoor("Watch Me Eat A Chicken SOLO!", "Enjoy Me ", "2024-08-03", "12:00 PM", address3, "Sunny and warm");

        List<Event> events = new List<Event> { lecture, reception, outdoor};

        foreach (var eventItem in events)
        {
            Console.WriteLine(eventItem.StandardDetails());
            Console.WriteLine(eventItem.FullDetails());
            Console.WriteLine(eventItem.ShortDetails());
            Console.WriteLine(new string('-', 60));
        }
    }
}