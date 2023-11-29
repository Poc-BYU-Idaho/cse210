using System.ComponentModel.DataAnnotations;

public class Video
{
    private string _title;

    private string _author;

    private int _length;

    private List<Comment> _comments;


    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author}\nLength: {_length}\nNumber of Comments: {_comments.Count}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetComment());
        }
    }
}