using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment math = new Assignment("Jonathan","Math");
        Console.WriteLine(math.GetSummary());

        MathAssignment calculus = new MathAssignment("Joe","Calculus","McGrawhill","Problems A-F");
        Console.WriteLine($"{calculus.GetSummary()}\n{calculus.GetHomeworkList()}");

        WritingAssignment religion = new WritingAssignment("Mary","Religion","Remember Lot's Wife - Elder Holland");
        Console.WriteLine($"{religion.GetSummary()}\n{religion.GetWritingInformation()}");
    }
}