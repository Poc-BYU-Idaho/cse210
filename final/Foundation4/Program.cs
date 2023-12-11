using System;

class Program
{
    static void Main(string[] args)
    {
        foreach (Activity activity in new List<Activity>()
        {
            new Running(4.8, "03 Nov 2022", 30),
            new Cycling(15, "03 Nov 2022", 45),
            new Swimming(16, "03 Nov 2022", 10)
        })
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}