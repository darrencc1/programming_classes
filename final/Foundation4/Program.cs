using System;
// One activity of each type, put them in the same list and call the GetSummary Method to display the results.
// Use Method Overriding for calculation methods.public class Program
public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 06, 3), 30, 3.0),
            new Cycling(new DateTime(2024, 06, 4), 45, 12.0),
            new Swimming(new DateTime(2024, 06, 7), 60, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}