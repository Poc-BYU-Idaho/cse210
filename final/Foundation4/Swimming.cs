public class Swimming : Activity
{
    public double _numberOfLaps;


    public Swimming(double numberOfLaps, string date, int duration) : base(date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }
    

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _duration * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}