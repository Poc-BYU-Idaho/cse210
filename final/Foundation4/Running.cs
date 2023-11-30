public class Running : Activity
{
    public double _distance;


    public Running(double distance, string date, int duration) : base(date, duration)
    {
        _distance = distance;
    }


    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _duration * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}