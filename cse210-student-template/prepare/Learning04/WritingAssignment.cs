
using System.Net;

public class WritingAssignment : Assignment
{
    protected string _title;
    protected string _author;

    public WritingAssignment(string studentName, string topic, string title, string author) : base (studentName, topic)
    {
        _title = title;
        _author = author;
    }

    public string GetWritingInfo()
    {
        return $"Name: {_studentName} -- Topic: {_topic} \n {_title} by {_author}\n";
    }
}