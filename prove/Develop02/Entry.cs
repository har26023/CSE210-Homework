class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _scriptureText;
    public string _wastedHours;


    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}\nScripture of the Day: {_scriptureText}\nHours Wasted Today: {_wastedHours}\n");
    }

    public void SetDate()
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();
    }
}