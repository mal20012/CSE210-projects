USing System;

public class Activity
{
    private string _activityName;
    private string _startMessage;
    private string _endMessage;
    private string _description;
    private int _duration = 0;
    static int _spinnerCounter = 0;
    public Activity(){
        _activityName = " ";
        _startMessage = _startMessage;
        _endMessage = endMessage;
        _description = description;
        _duration = 15;
    }

    public void DisplayStartMessage{
        _startMessage = $"Hello Welcome to the {_activityName}.";
        Console.WriteLine(_startMessage);
        Console.WriteLine();
    }
    public void DisplayEndMessage{
        _endMessage = $"You have spent {_userTime} seconds of the {_activityName}.";

        Console.WriteLine();
        Console.WriteLine("Proud of you! See you soon!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine(_endMessage);
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int numSeconds){
         Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSeconds)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Console.Write(" ");
    }

    public void ShowCountDown(int numSeconds){
        for (int i = numSeconds; i >= 1; i--)
        {
            Console.Write($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
}