public class Cycling : Activity
{
    public double _speed;


    public Cycling(double speed, string date, int duration) : base(date, duration)
    {
        _speed = speed;
    }


    public override double GetDistance()
    {
        return _speed * _duration / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}