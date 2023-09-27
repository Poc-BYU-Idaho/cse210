// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Player ronaldo = new Player("Christiano Ronaldo", 7);
ronaldo.Display();

Player john = new Player("John", 1);

Team cardinals = new Team("Cardinals");
cardinals.AddPlayer(ronaldo);

Team otherteam = new Team("Other Team");
otherteam.AddPlayer(john);

Match match1 = new Match(cardinals, otherteam);
match1.DecideWin();

cardinals.Display();
otherteam.Display();