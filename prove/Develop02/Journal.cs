public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal(List<Entry> entryList)
    {
        _entries = entryList;
    }
    public void AddEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        DateTime dateTimeDate = DateTime.Now;
        string currentDate = dateTimeDate.ToString();
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        string userEntry = Console.ReadLine();
        Entry entry = new Entry(currentDate, prompt, userEntry);
        _entries.Add(entry);
    }
    public Journal LoadFromFile()
    {
        Console.WriteLine("What file would you like to load a journal from ?");
        string fileName = Console.ReadLine();
        string[] loadedFile = System.IO.File.ReadAllLines(fileName);
        _entries.Clear();
        foreach (string entry in loadedFile)
        {
            string[] parts = entry.Split(";");
            Entry entryFromFile = new Entry(parts[1][1..21], parts[2][1..], parts[3][1..]);
            _entries.Add(entryFromFile);
        }
        Journal journal = new Journal(_entries);
        return journal;
    }
    public void SaveToFile()
    {
        Console.WriteLine("What file would you like to save to? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date; {entry._date} - Prompt; {entry._prompt}; {entry._entryText}");
            }
        }
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}