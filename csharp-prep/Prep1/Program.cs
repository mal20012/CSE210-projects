using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your firstname?");
                string firstname = Console.ReadLine();

        Console.Write("What is your second name?");
                string name = Console.ReadLine();
        
        Console.WriteLine("Your name is, " + firstname + name);
    }
}