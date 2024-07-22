using System;


namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected int Duration { get; private set; }

        public void StartMessage(string activityName, string description)
        {
            Console.WriteLine($"Starting {activityName} Activity");
            Console.WriteLine(description);
            Console.WriteLine($"This activity will last for {Duration} seconds. Take a breath and Prepare to begin...");
            Thread.Sleep(3000); // Pause for 3 seconds before starting
        }

        public void EndMessage(string activityName)
        {
            Console.WriteLine($"Good job! You have completed the {activityName} activity for {Duration} seconds.");
            Thread.Sleep(3000); // Pause for 3 seconds before ending
        }

        public void SetDuration(int duration)
        {
            Duration = duration;
        }

        protected void Pause(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine($"{i}...");
                Thread.Sleep(1000);
            }
        }

        public abstract void Run();
    }
}
