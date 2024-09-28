using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List <string> prompts = new List<string>
        {
            "If I had one thing I could do over today, what would it be?",
            "What was the highlight of your day and why?",
            "What did you learn today?",
            "What was the most challenging thing you faced today?",
            "How did you overcome it?",
            "How many people did you serve today?",
            "Who made your day better today?",
            "Did your day go as you had planned it?",
            "What do you most wish for tomorrow? ",
        };

        bool quit = false;
        while(!quit){
            Console.WriteLine("\n**** Welcome to the Journal App ****\n");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                string prompt = GetRandomPrompt(prompts);
                journal.AddEntry(prompt);
                break;
                case "2":
                journal.Display();
                break;
                case "3":
                journal.SaveJournalFile();
                break;
                case "4":
                journal.LoadJournalFile();
                break;
                case "5":
                Console.WriteLine("Thank you for using the Journal App!");
                break;
                default:
                Console.WriteLine("Sorry that option is invalid.");
                break;
            }
        }
    }
    static string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}