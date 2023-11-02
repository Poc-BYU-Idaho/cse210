public class ListingActivity : Activity
{
    private List<string> _promptsList = new List<string>() {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    
    private Random rng = new Random();


    public ListingActivity(string name = "Listing Activity", string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base(name, description)
    {

    }   


    public void RunActivity()
    {
        PrepareActivity();

        int numberOfItemsListed = 0;
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("--- " + _promptsList[rng.Next(0, _promptsList.Count)] + " ---");
        Console.Write("You may begin in: ");
        CountdownPause(5);
        Console.WriteLine();
        _activityDurationStopwatch.Start();
        while (_activityDurationStopwatch.Elapsed < TimeSpan.FromSeconds(_duration))
        {
            Console.Write(" > ");
            Console.ReadLine();
            numberOfItemsListed ++;
        }
        Console.WriteLine($"You listed {numberOfItemsListed} items!\n");

        EndActivity();
    }
}