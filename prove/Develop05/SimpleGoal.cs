public class SimpleGoal : Goal
{
    public SimpleGoal(int pointsWorth, string name, bool isCompleted = false, int pointsEarned = 0) : base(isCompleted, pointsWorth, pointsEarned, name)
    {

    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal  <|||-|-@%^%^%@-|-|||>  {_isCompleted}  <|||-|-@%^%^%@-|-|||>  {_pointsWorth}  <|||-|-@%^%^%@-|-|||>  {_pointsEarned}  <|||-|-@%^%^%@-|-|||>  {_name}";
    }

    public override void AddPoints()
    {
        if (isCompleted() == false)
        {
            _pointsEarned += _pointsWorth;
            _isCompleted = true;
        }
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