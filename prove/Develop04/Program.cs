using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        int breathingNum = 0;
        int reflectionNum = 0;
        int listingNum = 0;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingNum++;
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    reflectionNum++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingNum++;
                    break;

                case "4":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }

        Activity.ShowSpinner(1);
        Console.WriteLine($"You completed these activities this amount of times:\nBreathing Activity: {breathingNum}\nReflection Activity: {reflectionNum}\nListing Activity: {listingNum}");
    }
}