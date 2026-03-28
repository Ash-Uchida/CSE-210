using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVidStuff()
    {
        Console.WriteLine($"{_title} by {_author} ({_length} minutes)");
        Console.WriteLine($"Comments: ({_comments.Count})");

        foreach(Comment c in _comments)
        {
            Console.WriteLine($" - {c.PersonsComment()}");

        }
        Console.WriteLine();
    }

}

