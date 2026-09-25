using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Initializes the list and input variables
        List<int> numbers = new List<int>();
        int input;
        
        // User inputs values they want to add to the list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }
        while (input != 0);

        // Calculates the sum of the list
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculates the average of the list
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Finds the largest number in the list
        int largest = 0;
        foreach(int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

    }
}