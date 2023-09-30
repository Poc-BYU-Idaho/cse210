using System;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> _entries = new List<Entry>();
        Journal selectedJournal = new Journal();
        int x = 1;
        do
        {
            Console.WriteLine("Welcome to the Journal Program!\nPlease select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                selectedJournal.AddEntry();
            }
            else if (userChoice == "2")
            {
                selectedJournal.Display();
            }
            else if (userChoice == "3")
            {
                selectedJournal = selectedJournal.LoadFromFile();
            }
            else if (userChoice == "4")
            {
                selectedJournal.SaveToFile();
            }
            else if (userChoice == "5")
            {
                break;
            }
        }
        while (x == 1);
    }
}