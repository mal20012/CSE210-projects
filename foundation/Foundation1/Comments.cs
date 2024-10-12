using System;

public class Comment
{
    private string _name;
    private string _input;
    public Comment(string name, string input)
    {
        _name = name;
        _input = input;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_name} - {_input}");
    }
}