using System.ComponentModel;

public class Event
{
    private string _title;

    public string _description;

    private string _date;

    private string _time;

    private Address _address;


    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    public void GetDetails()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nTime: {_date} at {_time}\nAddress: {_address.GetAddressString()}");
    }

    public virtual void GetFullDetails()
    {
        GetDetails();
    }

    public void GetShortDetails()
    {
        Console.WriteLine($"Event Type: {GetType()}\nTitle: {_title}\nDate: {_date}");
    }
}