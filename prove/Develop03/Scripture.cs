class Scripture
{
    private List<Word> _wordList;
    private string _scripture;
    private Reference _reference;
    private Random _random = new Random();

    public Scripture()
    {
        _wordList = new List<Word>();
        _scripture = "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.";
        _reference = new Reference("Mosiah",3,19);

        string[] tempWordList = _scripture.Split(' ');
        foreach(string word in tempWordList)
        {
            _wordList.Add(new Word(word));
        }
    }

    public Scripture(Reference reference, string scripture)
    {
        _wordList = new List<Word>();
        _reference = reference;
        _scripture = scripture;

        string[] tempWordList = _scripture.Split(' ');
        foreach(string word in tempWordList)
        {
            _wordList.Add(new Word(word));
        }
    }

    public void setHiddenWords()
    {
        for(int i = 0; i < 3; i++)
        {
            int randomInt = _random.Next(0, _wordList.Count);
            _wordList[randomInt].setIsHidden(true);
        }
    }

    public bool completelyHidden()
    {
        foreach(Word word in _wordList)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void Display()
    {
        Console.Write($"{_reference.Display()}");
        foreach(Word word in _wordList)
        {
            Console.Write($" {word.Display()}");
        }
        Console.WriteLine();
    }
}