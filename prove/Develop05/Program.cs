using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPointsEarned = 0;
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYou have {totalPointsEarned} points.\n\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event   \n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoice = Console.ReadLine().Trim();
            Console.WriteLine();
            switch (userChoice)
            {
                case "1":
                    Console.Write("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
                    string goalChoice = Console.ReadLine().Trim();
                    switch (goalChoice)
                    {
                        case "1":
                            Console.Write("What is the name of your goal? ");
                            string simpleGoalName = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            int simplePointsWorth = Convert.ToInt32(Console.ReadLine());
                            goals.Add(new SimpleGoal(simplePointsWorth, simpleGoalName));
                            break;

                        case "2":
                            Console.Write("What is the name of your goal? ");
                            string eternalGoalName = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            int eternalPointsWorth = Convert.ToInt32(Console.ReadLine());
                            goals.Add(new EternalGoal(eternalPointsWorth, eternalGoalName));
                            break;
                        case "3":
                            Console.Write("What is the name of your goal? ");
                            string checklistGoalName = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            int checklistPointsWorth = Convert.ToInt32(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int checklistLength = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int completionPoints = Convert.ToInt32(Console.ReadLine());
                            goals.Add(new ChecklistGoal(checklistPointsWorth, checklistGoalName, checklistLength, completionPoints));
                            break;
                        default:
                            break;
                    }
                    break;
                case "2":
                    int i = 1;
                    Console.WriteLine("The goals are:");
                    foreach (Goal goal in goals)
                    {
                        if (goal.isCompleted())
                        {
                            Console.Write($"{i}: [X] {goal.GetName()}");
                            goal.GetProgress();
                        }
                        else
                        {
                            Console.Write($"{i}: [ ] {goal.GetName()}");
                            goal.GetProgress();
                        }
                        i ++;
                    }
                    break;
                case "3":
                    Console.Write("What is the file name for the goal file? ");
                    string saveFile = Console.ReadLine();
                    GoalFileHandler.WriteGoalsToFile(saveFile, goals);
                    break;
                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    string fileToLoad = Console.ReadLine();
                    goals = GoalFileHandler.ReadAndCreateGoals(fileToLoad);
                    totalPointsEarned = GoalFileHandler.ReadPoints(fileToLoad);
                    break;
                case "5":
                    Console.WriteLine("The goals are:");
                    int ii = 1;
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine($"{ii}: {goal.GetName()}");
                        ii ++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int accomplishedGoal = Convert.ToInt32(Console.ReadLine());
                    if (accomplishedGoal <= goals.Count && !goals[accomplishedGoal - 1].isCompleted())
                    {
                        goals[accomplishedGoal - 1].AddPoints();
                        int acquiredPoints = goals[accomplishedGoal - 1].GetPointsWorth();
                        totalPointsEarned += acquiredPoints;
                        Console.WriteLine($"\nCongratulations! You have earned {acquiredPoints} points!\nYou now have {totalPointsEarned} points.");
                    }
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}