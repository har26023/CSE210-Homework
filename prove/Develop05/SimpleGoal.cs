public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
    }

    public override string GetSaveString()
    {
    return $"{base.GetSaveString()}|{_isCompleted}";
    }
}