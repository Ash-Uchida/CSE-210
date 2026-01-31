// you want to intilaize this class
public class Entry
{
    // we always start with attributes then end this file with methods
    public DateTime _date;
    public string _prompt;
    public string _entry;

    public void Display()
    {
        // just printing out our entrys
        Console.WriteLine($"Date: {_date} \n Prompt: {_prompt} \n {_entry} \n");

    }


}

