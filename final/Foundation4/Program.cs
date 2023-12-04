using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>(){new Running(4.8, "03 Nov 2022", 30), new Cycling(15, "03 Nov 2022", 45), new Swimming(16, "03 Nov 2022", 10)};

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}