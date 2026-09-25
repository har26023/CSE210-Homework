using System;

class Program
{
    // Prints out welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Gets and returns user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }

    // Gets and returns user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int UserNumber = int.Parse(Console.ReadLine());
        return UserNumber;
    }

    // Gets user's birth year and sets the out variable num to it
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    // Squares a number and returns it
    static int SquareNumber(int x)
    {
        int Square = x * x;
        return Square;
    }

    // Displays the user's name then squared favorite number and birth year
    static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        int age = DateTime.Now.Year - year;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        PromptUserBirthYear(out int year);
        int SquaredNumber = SquareNumber(UserNumber);
        DisplayResult(UserName, SquaredNumber, year);
    }
}