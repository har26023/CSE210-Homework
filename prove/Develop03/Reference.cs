class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd = 0;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
    }

    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = firstVerse;
        _verseEnd = lastVerse;
    }

    public string Display()
    {
        if(_verseEnd == 0)
        {
            return($"{_book} {_chapter}:{_verseStart}");
        }
        else
        {
            return($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }
    }
}