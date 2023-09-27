public class Player
{
    private string _name;
    private int _jerseyNumber;

    public Player(string name, int jerseyNumber)
    {
        _name = name;
        _jerseyNumber = jerseyNumber;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} {_jerseyNumber}");
    }
}