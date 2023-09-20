using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = -1;

        // Console.Write("What is the magic number? ");
        // string userNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userNumber);

        Random rng = new Random();
        string keepPlaying = "yes";

        while (keepPlaying =="yes")
        {
            int guessCount = 0;
            int magicNumber = rng.Next(1, 101);

            while (guess != magicNumber)
            {
                guessCount += 1;
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.Write($"You guessed it!\nGuess Count: {guessCount}\nWould you like to keep playing? (yes/no) ");
                    keepPlaying = Console.ReadLine();
                }
            }
        }
    }
}