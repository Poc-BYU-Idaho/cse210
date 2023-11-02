public class BreathingActivity : Activity
{
    public BreathingActivity(string name = "Breathing Activity", string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(name, description)
    {

    }


    public void RunActivity()
    {
        PrepareActivity();

        _activityDurationStopwatch.Start();
        while (_activityDurationStopwatch.Elapsed < TimeSpan.FromSeconds(_duration))
        {
            Console.Write("Breathe in...");
            CountdownPause(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            CountdownPause(6);
            Console.WriteLine("\n");
        }

        EndActivity();
    }
}