using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected double _duration;
    protected Stopwatch _activityDurationStopwatch = new Stopwatch();


    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    protected void PrepareActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string stringDuration = Console.ReadLine().Trim();
        _duration = double.Parse(stringDuration);

        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinnerPause(5);
        Console.WriteLine();
    }

    protected void EndActivity()
    {
        Console.WriteLine($"Well Done!!");
        SpinnerPause(5);
        Console.WriteLine();
        if (_duration > 1 || _duration < 1)
        {
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        }
        else
        {
            Console.WriteLine($"You have completed another {_duration} second of the {_name}.");
        }
        SpinnerPause(5);

    }

    protected void SpinnerPause(double duration)
    {
        Stopwatch _stopwatch = new Stopwatch();
        _stopwatch.Start();
        while (_stopwatch.Elapsed < TimeSpan.FromSeconds(duration))
        {
            Console.Write("|");
            Thread.Sleep(140);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(140);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(140);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(140);
            Console.Write("\b \b");
        }
    }

    protected void CountdownPause(int duration)
    {
        for (int i = 0; i < duration; duration --)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}