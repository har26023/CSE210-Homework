using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letter;

        // Determines what letter grade is given depending on user input.
        if(grade > 90 || grade == 90)
        {
            letter = "A";
        }
        else if (grade > 80 || grade == 80)
        {
            letter = "B";
        }
        else if (grade > 70 || grade == 70)
        {
            letter = "C";
        }
        else if (grade > 60 || grade == 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        // Detects whether the grade is a + or a -.
        if(grade > 60 && grade < 93)
        {
            if((grade / 10) > 7 || (grade / 10) == 7)
            {
                letter = letter + "+";
            }
            else if ((grade / 10) < 3)
            {
                letter = letter + "-";
            }
        }

        // Prints out final letter grade.
        Console.WriteLine(letter);

        // Determines if the class was passed or failed.
        if (grade > 70 || grade == 70)
        {
            Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("You unfortunately didn't pass the class, there's always next year!");
        }
    }
}