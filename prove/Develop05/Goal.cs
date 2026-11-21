public class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _isCompleted = false;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public virtual void Display()
    {
        if (_isCompleted)
        {
            Console.WriteLine($"[X] {_title} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_title} ({_description})");
        }
    }

    public virtual string GetSaveString()
    {
        return $"{GetType().Name}:{_title}|{_description}|{_points}";
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetComplete()
    {
        _isCompleted = true;
    }

    public string GetTitle()
    {
        return _title;
    }
}