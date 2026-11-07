class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void ShowPrologue()
    {
        Console.WriteLine($"{_name}\n{_description}");
    }

    public static void ShowSpinner(int seconds)
    {
        List<string> frames = new List<string> {"-", "/", "|", "\\"};
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while(DateTime.Now < end)
        {
            Console.Write(frames[i]);
            Thread.Sleep(250);
            Console.Write("\b");
            i = (i+1) % frames.Count;
        }
        Console.WriteLine(" \b");
    }

    protected void ShowEpilogue()
    {
        Console.WriteLine($"Well done!\nYou have completed {_duration} seconds of the {_name}.");
    }

    public int GetDuration()
    {
        return _duration;
    }

    protected void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected string RandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }
}