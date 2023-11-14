public class GoalFileHandler
{
    public static void WriteGoalsToFile(string fileName, List<Goal> goalsToWrite)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in goalsToWrite)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public static List<Goal> ReadAndCreateGoals(string fileName)
    {
        List<Goal> goals = new List<Goal>();
        string[] fileContents = System.IO.File.ReadAllLines(fileName);
        foreach (string line in fileContents)
        {
            string[] parts = line.Split("  <|||-|-@%^%^%@-|-|||>  ");
            bool isCompleted = Convert.ToBoolean(parts[1]);
            int pointsWorth = Convert.ToInt32(parts[2]);
            int pointsEarned = Convert.ToInt32(parts[3]);
            string goalName = parts.Last();
            if (parts[0] == "SimpleGoal")
            {
                goals.Add(new SimpleGoal(pointsWorth, goalName, isCompleted));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                int checklistLength = Convert.ToInt32(parts[4]);
                int timesCompleted = Convert.ToInt32(parts[5]);
                int completionPoints = Convert.ToInt32(parts[6]);
                goals.Add(new ChecklistGoal(pointsWorth, goalName, checklistLength, completionPoints, isCompleted, pointsEarned, timesCompleted));
            }
            else if (parts[0] == "EternalGoal")
            {
                goals.Add(new EternalGoal(pointsWorth, goalName, isCompleted, pointsEarned));
            }
        }
        return goals;
    }

    public static int ReadPoints(string fileName)
    {
        int totalPointsEarned = 0;
        string[] filecontents = System.IO.File.ReadAllLines(fileName);
        foreach (string line in filecontents)
        {
            string[] parts = line.Split("  <|||-|-@%^%^%@-|-|||>  ");
            totalPointsEarned += Convert.ToInt32(parts[3]);
        }
        return totalPointsEarned;
    }
}