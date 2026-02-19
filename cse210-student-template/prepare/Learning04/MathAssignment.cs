
public class MathAssignment : Assignment
{
    protected string _textBookSection;
    protected string _problems;
    
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base (studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Name: {_studentName} -- Topic: {_topic} \n Section {_textBookSection} Problems {_problems} \n";
    }

}