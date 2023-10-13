using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 1, 1, 2);
        Scripture scripture = new Scripture(reference, "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days. Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.");

        string userInput = "";
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            userInput = Console.ReadLine().ToLower().Trim();
            scripture.HideWords();
        }
        while (userInput != "quit");
    }
}