using System;

class Program
{
    static void Main(string[] args)
    {
        Reception reception = new Reception("rsvpemail@gmail.com", "title", "a description", "12/10/2023", "5PM", new Address("test address", "test city", "test state", "test country"));
        reception.GetDetails();
        reception.GetFullDetails();
        reception.GetShortDetails();

        OutdoorGathering outdoorGathering = new OutdoorGathering("It will be sunny.", "title", "a description", "12/10/2023", "5PM", new Address("test address", "test city", "test state", "test country"));
        outdoorGathering.GetDetails();
        outdoorGathering.GetFullDetails();
        outdoorGathering.GetShortDetails();

        Lecture lecture = new Lecture("A speaker", 10, "title", "a description", "12/10/2023", "5PM", new Address("test address", "test city", "test state", "test country"));
        lecture.GetDetails();
        lecture.GetFullDetails();
        lecture.GetShortDetails();
    }
}