using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int nombre = -1;
        while (nombre != 0) {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            string answer = Console.ReadLine();
            nombre = int.Parse(answer);

            if (nombre != 0){
                numbers.Add(nombre);

            }
        }   
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("The sum is: " + sum);
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine("The average is: " + average);

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.Write("The max is: "+ max);
    }   
}