class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}\n{entry._entryText}\nScripture of the Day: {entry._scriptureText}\nHours Wasted Today: {entry._wastedHours}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Clear the attribute list and make a new list full of all of the entries from the file
        _entries.Clear();
        List<string> previousEntries = File.ReadAllLines(file).ToList();

        // Use a for loop to iterate through all data from the new list
        for(int i = 0; i < previousEntries.Count; i += 4)
        {
            // Working with the top line to get the date and the prompt
            string headerLine = previousEntries[i];
            headerLine = headerLine.Replace("Date: ", "");
            string[] parts = headerLine.Split(" Prompt: ", 2);
            string date = parts[0];
            string prompt = parts[1];

            // Gets the user entry from the second line and other lines
            string entryLine = previousEntries[i+1];
            string scriptureLine = previousEntries[i+2];
            string wastedHoursLine = previousEntries[i+3];

            // Creates the new object out of the old string
            Entry newEntry = new Entry();
            newEntry._date = date;
            newEntry._promptText = prompt;
            newEntry._entryText = entryLine;
            newEntry._scriptureText = scriptureLine;
            newEntry._wastedHours = wastedHoursLine;
            
            _entries.Add(newEntry);
        }
    }
}