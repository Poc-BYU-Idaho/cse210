public class Rectangle : Shape
{
    float _length;
    float _width;


    public Rectangle(string color, float length, float width) : base(color)
    {
        _length = length;
        _width = width;
    }


    public override double GetArea()
    {
        return _length * _width;
    }
}