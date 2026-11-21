public class Checklist : Goal
{
    private int _timesDone;
    private int _goal;
    private int _bonusPoints;

    public Checklist(string title, string description, int points, int timesDone, int goal, int bonusPoints) : base(title, description, points)
    {
        _timesDone = timesDone;
        _goal = goal;
        _bonusPoints = bonusPoints;
    }

    public void IncreaseTimesDone()
    {
        _timesDone += 1;
    }

    public bool IsDone()
    {
        return _timesDone >= _goal;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override void Display()
    {
        if (_isCompleted)
        {
            Console.WriteLine($"[X] {_title} ({_description}) -- Currently completed: {_timesDone}/{_goal}");
        }
        else
        {
            Console.WriteLine($"[ ] {_title} ({_description}) -- Currently completed: {_timesDone}/{_goal}");
        }
    }

    public override string GetSaveString()
    {
    return $"{base.GetSaveString()}|{_bonusPoints}|{_goal}|{_timesDone}";
    }
}