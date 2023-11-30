public class OutdoorGathering : Event
{
    private string _weatherStatement;

    
    public OutdoorGathering(string weatherStatement, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }


    public override void GetFullDetails()
    {
        GetDetails();
        Console.WriteLine($"Weather Statement: {_weatherStatement}");
    }
}