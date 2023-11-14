public abstract class Goal
{
    protected bool _isCompleted;

    protected int _pointsWorth;

    protected int _pointsEarned;

    protected string _name;


    public Goal(bool isCompleted, int pointsWorth, int pointsEarned, string name)
    {
        _isCompleted = isCompleted;
        _pointsWorth = pointsWorth;
        _pointsEarned = pointsEarned;
        _name = name;
    }

    
    public abstract string GetStringRepresentation();

    public abstract void AddPoints();

    public bool isCompleted()
    {
        return _isCompleted;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract int GetPointsWorth();

    public abstract void GetProgress();
}