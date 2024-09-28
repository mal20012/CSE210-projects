using System;

public class Journal {
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt){
        Console.Write(prompt + " ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        entries.Add(new Entry(prompt, response, date));
    }

    public void Display(){
        foreach(Entry entry in entries){
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveJournalFile() {
        Console.Write("Write file name: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter (filename)){
            outputFile.WriteLine("Date, Prompt, Response");

            foreach (Entry entry in entries){
                outputFile.WriteLine($"{entry.GetDate()}, {entry.GetPrompt().Replace("," , ",,")}");
            }
        }
        Console.WriteLine("Saved");

    }
    public void LoadJournalFile(){
        Console.Write("Enter File name: ");
        string filename = Console.ReadLine();
        entries.Clear();

        using (StreamReader reader = new StreamReader(filename)){
            string headerLine = reader.ReadLine();

            while (!reader.EndOfStream){
                string line = reader.ReadLine();
                string[] parts = line.Split(',');

                string date = parts[0];
                string prompt = parts[1].Replace(",,", ",");
                string response = parts[2].Replace(",,", ",");

                entries.Add(new Entry(prompt, response, date));
            }
        }
        Console.WriteLine("Loaded");
    }

}