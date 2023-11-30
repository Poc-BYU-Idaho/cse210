public abstract class Activity
{
    private string _date;

    protected int _duration;


    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }


    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_duration} min): Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}