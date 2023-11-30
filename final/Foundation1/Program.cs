using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>()
        {
            new Video("Cool Video", "Bob", 20, new List<Comment>() {new Comment("Joe", "This is my comment."), new Comment("Jake", "Good"), new Comment("James", "Bad")}),
    
            new Video("Cooler Video", "Bill", 500, new List<Comment>(){new Comment("Chad", "Cool"), new Comment("Carson", "Boring"), new Comment("Charlie", "Great")}),

            new Video("Coolest Video", "Benson", 1260, new List<Comment>(){new Comment("Roy", "Nice video"), new Comment("Ray", "Could be better"), new Comment("Ryan", "Video is too long"), new Comment("Rigby", "I am the fourth commentor")})
        };

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine("");
        }
    }
}