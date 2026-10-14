using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator randomPrompt = new PromptGenerator();
        Journal journal = new Journal();
        int choice = 0;


        while(choice != 5){
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Entry userEntry = new Entry();
                userEntry.SetDate();
                userEntry._promptText = randomPrompt.GetRandomPrompt();
                Console.Write($"{userEntry._promptText}\n> ");
                userEntry._entryText = Console.ReadLine();
                Console.Write("What is the scripture of the day?\n> ");
                userEntry._scriptureText = Console.ReadLine();
                Console.Write("How many hours have you wasted today?\n> ");
                userEntry._wastedHours = Console.ReadLine();
                journal.AddEntry(userEntry);
            }
            else if (choice == 2)
            {
                Console.Write("\n");
                journal.DisplayAll();
                continue;
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                journal.LoadFromFile(Console.ReadLine());
                continue;
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                journal.SaveToFile(Console.ReadLine());
                continue;
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                continue;
            }
        }
    }
}