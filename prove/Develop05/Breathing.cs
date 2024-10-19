using System;
public class Breathing : Activity
{  
    public Breathing()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void PromptBreathing()
    {
        DateTime endTime = GetEndTime(GetDuration());
        DateTime currentTime = GetCurrentTime();
        
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountDown(2);
        Console.WriteLine();
        Console.Write("Breathe out...");
        ShowCountDown(3);

        while (currentTime <= endTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(6);
            currentTime = DateTime.Now;
        }
    }
}