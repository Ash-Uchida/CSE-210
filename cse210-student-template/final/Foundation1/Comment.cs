using System.Collections.Generic;
public class Comment

{
    public string _name;
    public string _commentText;

    public Comment(string name, string text)
    {
        _name = name;
        _commentText = text;
    }

    //make a method that comines the two and return them so we jjust need to call that method
    public string PersonsComment()
    {
        return $"{_name}: {_commentText}";
    }
}

