using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"{fraction1.GetFractionString()}\n{fraction1.GetDecimalValue()}");

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"{fraction2.GetFractionString()}\n{fraction2.GetDecimalValue()}");

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine($"{fraction3.GetFractionString()}\n{fraction3.GetDecimalValue()}");

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine($"{fraction4.GetFractionString()}\n{fraction4.GetDecimalValue()}");
        
        Fraction myFraction = new Fraction();
        Random random = new Random();

        for(int i = 1; i <= 20; i++)
        {
            myFraction.SetTop(random.Next(1, 100));
            myFraction.SetBottom(random.Next(1, 100));
            Console.WriteLine($"Fraction {i}: string: {myFraction.GetFractionString()} Number: {myFraction.GetDecimalValue()}");
        }
    }
}