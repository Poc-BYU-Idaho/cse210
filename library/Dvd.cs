public class Dvd : Loanable
{
    private string _title = "untitled";

    public Dvd(string title)
    {
        _title = title;
    }

    public override void Display()
    {
        Console.WriteLine($"Title: {_title}");
        base.Display();
    }
}