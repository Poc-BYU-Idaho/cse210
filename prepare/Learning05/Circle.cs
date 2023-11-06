public class Circle : Shape
{
    float _radius;


    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }


    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}