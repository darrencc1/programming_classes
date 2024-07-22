using System;

namespace MindfulnessApp
{
    public class ReflectionActivity : Activity
    {
        private static readonly List<string> Prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of when you were patient with others?",
            "Think of a time when you stood up for yourself.",
            "Remember a time when you felt the presence of God"
        };

        private static readonly List<string> Questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity(int duration)
        {
            SetDuration(duration);
        }

        public override void Run()
        {
            StartMessage("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Random random = new Random();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
            Pause(3);

            for (int i = 0; i < Duration / 15; i++)
            {
                Console.WriteLine(Questions[random.Next(Questions.Count)]);
                Pause(6);
            }

            EndMessage("Reflection");
        }
    }
}
