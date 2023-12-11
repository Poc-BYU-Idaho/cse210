using System;

class Program
{
    static void Main(string[] args)
    {
        foreach (Event eventObject in new List<Event>()
        {
            new Reception("rsvpemail@gmail.com", "title", "a description", "12/10/2023", "5PM", new Address("test address", "test city", "test state", "test country")),
            new OutdoorGathering("It will be sunny.", "title", "a description", "12/10/2023", "5PM", new Address("test address", "test city", "test state", "test country")),
            new Lecture("A speaker", 10, "title", "a description", "12/10/2023", "5PM", new Address("test address", "test city", "test state", "test country"))
        })
        {
                eventObject.GetDetails();
                Console.WriteLine();
                eventObject.GetFullDetails();
                Console.WriteLine();
                eventObject.GetShortDetails();
                Console.WriteLine("\n\n");
        }
    }
}