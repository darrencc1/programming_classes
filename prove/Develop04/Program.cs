using System;
// Chat Gpt was used to help organize this code better and help me fix some issues. 
namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();
                // Chat gpt helped me with the switch case, I was struggling and this really helped my code to actually work
                // This also helped me to understand switch cases better an dhow to use them.
                if (choice == "4")
                {
                    break;
                }

                Console.Write("Enter duration of activity in seconds: ");
                int duration = int.Parse(Console.ReadLine());

                Activity activity = null;

                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity(duration);
                        break;
                    case "2":
                        activity = new ReflectionActivity(duration);
                        break;
                    case "3":
                        activity = new ListingActivity(duration);
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        continue;
                }

                activity.Run();
            }
        }
    }
}
