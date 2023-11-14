public class EternalGoal : Goal
{
    public EternalGoal(int pointsWorth, string name, bool isCompleted = false, int pointsEarned = 0) : base(isCompleted, pointsWorth, pointsEarned, name)
    {
        
    }

    
    public override string GetStringRepresentation()
    {
        return $"EternalGoal  <|||-|-@%^%^%@-|-|||>  {_isCompleted}  <|||-|-@%^%^%@-|-|||>  {_pointsWorth}  <|||-|-@%^%^%@-|-|||>  {_pointsEarned}  <|||-|-@%^%^%@-|-|||>  {_name}";
    }

    public override void AddPoints()
    {
        _pointsEarned += _pointsWorth;
    }

    public override int GetPointsWorth()
    {
        return _pointsWorth;
    }

    public override void GetProgress()
    {
        Console.WriteLine();
    }
}