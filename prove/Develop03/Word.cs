class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void setIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public string Display()
    {
        if(_isHidden)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}