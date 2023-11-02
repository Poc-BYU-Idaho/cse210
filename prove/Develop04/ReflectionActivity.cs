public class ReflectionActivity : Activity
{
    private List<string> _promptsList = new List<string>() {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

    private List<string> _secondPromptsList = new List<string>() {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    private Random rng = new Random();


    public ReflectionActivity(string name = "Reflection Activity", string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(name, description)
    {

    }   


    public void RunActivity()
    {
        PrepareActivity();

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine("--- " + _promptsList[rng.Next(0, _promptsList.Count)] + " ---" + "\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        CountdownPause(5);
        Console.Clear();
        _activityDurationStopwatch.Start();
        while (_activityDurationStopwatch.Elapsed < TimeSpan.FromSeconds(_duration))
        {
            Console.Write(_secondPromptsList[rng.Next(0, _secondPromptsList.Count)] + " ");
            SpinnerPause(15);
            Console.WriteLine("\n");
        }

        EndActivity();
    }
}