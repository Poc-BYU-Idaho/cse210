public class Lecture : Event
{
    private string _speakerName;

    private int _capacity;

    
    public Lecture(string speakername, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speakerName = speakername;
        _capacity = capacity;
    }


    public override void GetFullDetails()
    {
        GetDetails();
        Console.WriteLine($"Speaker: {_speakerName}\nCapacity: {_capacity}");
    }
}