public class ChecklistGoal : Goal
{
    private int _checklistLength;

    private int _timesCompleted;

    private int _completionPoints;

    public ChecklistGoal(int pointsWorth, string name, int checklistLength, int completionPoints, bool isCompleted = false, int timesCompleted = 0, int pointsEarned = 0) : base(isCompleted, pointsWorth, pointsEarned, name)
    {
        _checklistLength = checklistLength;
        _timesCompleted = timesCompleted;
        _completionPoints = completionPoints;
    }


    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal  <|||-|-@%^%^%@-|-|||>  {_isCompleted}  <|||-|-@%^%^%@-|-|||>  {_pointsWorth}  <|||-|-@%^%^%@-|-|||>  {_pointsEarned}  <|||-|-@%^%^%@-|-|||>  {_checklistLength}  <|||-|-@%^%^%@-|-|||>  {_timesCompleted}  <|||-|-@%^%^%@-|-|||>  {_completionPoints}  <|||-|-@%^%^%@-|-|||>  {_name}";
    }

    public override void AddPoints()
    {
        if (isCompleted() == false)
        {
            if (_timesCompleted + 1 == _checklistLength)
            {
                _pointsEarned += _pointsWorth;
                _pointsEarned += _completionPoints;
                _timesCompleted ++;
                _isCompleted = true;
            }
            else
            {
                _pointsEarned += _pointsWorth;
                _timesCompleted ++;
            }
        }
    }

    public override int GetPointsWorth()
    {
        if (isCompleted())
        {
            return _pointsWorth + _completionPoints;
        }
        else
        {
            return _pointsWorth;
        }
    }

    public override void GetProgress()
    {
        Console.WriteLine($" -- Currently completed: {_timesCompleted}/{_checklistLength}");
    }
}