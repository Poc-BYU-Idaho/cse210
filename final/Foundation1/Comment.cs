public class Comment
{
    private string _commentorName;

    private string _commentText;


    public Comment(string commentorName, string commentText)
    {
        _commentorName = commentorName;
        _commentText = commentText;
    }


    public string GetComment()
    {
        return $"{_commentorName}: {_commentText}";
    }
}