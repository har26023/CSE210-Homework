class ListingActivity : Activity
{
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        ShowPrologue();

        Console.Write("\nHow long, in seconds, would you like for your session to be?: ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get ready... ");
        CountDown(3);
        Console.Clear();

        Console.WriteLine($"List as many responses as you can to the following prompt:\n\n ---- {RandomPrompt(_prompts)} ----");
        Console.Write("You may begin in: ");
        CountDown(5);
        DateTime end = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine();

        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(" > ");
            Console.ReadLine();
            i++;
        }

        Console.WriteLine($"You listed {i} items!\n");
        ShowEpilogue();
        ShowSpinner(4);
    }
}