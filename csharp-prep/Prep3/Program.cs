using System;

class Program
{
    static void Main(string[] args)
    {
        // Obtain magic number
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 100);

        // Declare Guess, Tracker, and Continue variables
        int Guess;
        int Tracker = 0;
        string Continue = "yes";

        do
        {
            MagicNumber = randomGenerator.Next(1,100);
            // Loop while user hasn't guessed the magic number
            do
            {
            // Obtain guess
            Console.Write("What is your guess? ");
            Guess = int.Parse(Console.ReadLine());
            Tracker++;
            }
            while (Guess != MagicNumber);
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Number of Guesses: {Tracker}");
            Tracker = 0;
            Console.Write("Do you want to continue? (yes/no) ");
            Continue = Console.ReadLine();
        }
        while (Continue == "yes");
    }
}