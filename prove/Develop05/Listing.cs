using System;

public class Listing : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are the things you want to improve in your life?",
        "When was the last time you felt a deep sense of gratitude?",
    };

    public Listing()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public void PromptListing()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
                
        DateTime endTime = GetEndTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
}