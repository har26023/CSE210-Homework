class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    private void BreatheIn()
    {
        Console.Write("Breathe in... ");
        CountDown(3);
        Console.WriteLine();
    }

    private void BreatheOut()
    {
        Console.Write("Breathe out... ");
        CountDown(5);
        Console.WriteLine();
    }

    public void Run()
    {
        ShowPrologue();

        Console.Write("\nHow long, in seconds, would you like for your session to be?: ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get ready... ");
        CountDown(3);
        Console.WriteLine("\n");

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            BreatheIn();
            BreatheOut();
            Console.WriteLine();
            Thread.Sleep(1000);
        }

        ShowEpilogue();
        ShowSpinner(4);
    }
}