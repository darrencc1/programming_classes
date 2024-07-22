using System;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(int duration)
        {
            SetDuration(duration);
        }

        public override void Run()
        {
            StartMessage("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            for (int i = 0; i < Duration / 15; i++)
            {
                Console.WriteLine("Breathe in...");
                Pause(5);
                Console.WriteLine("Breathe out...");
                Pause(5);
            }
            EndMessage("Breathing");
        }
    }
}
