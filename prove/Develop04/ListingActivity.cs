using System;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private static readonly List<string> Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are some strengths of yours?",
            "Who are people that you have helped this week?",
            "How did you help influence others for good this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "How can you start to become like your personal heroes?"
        };

        public ListingActivity(int duration)
        {
            SetDuration(duration);
        }

        public override void Run()
        {
            StartMessage("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Random random = new Random();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
            Pause(3);

            List<string> items = new List<string>();
            for (int i = 0; i < Duration; i++)
            {
                Console.Write("Enter an item: ");
                items.Add(Console.ReadLine());
            }

            Console.WriteLine($"You have listed {items.Count} items.");
            EndMessage("Listing");
        }
    }
}
