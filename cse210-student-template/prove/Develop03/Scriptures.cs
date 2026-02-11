using System;
public class Scriptures
{
    private Reference _reference;
    private List<Words> _words = new List<Words>();
    private Random _random = new Random();

    // first we need our constructor
    public Scriptures( Reference reference, string text)
    {
        _reference = reference;
        // but we can't just do _words = text;
        // we need to Split the text into words and add to list
        foreach(string i in text.Split(" "))
        {
            _words.Add(new Words(i));
        }
        
    }


    public void Display()
    {
        // this is where you print the reference 
        Console.WriteLine(_reference.GetDisplayText());

        // this prints the scripture
        foreach(Words i in _words)
        {
            Console.Write(i.GetDisplayText() + " " );  
        } 
        Console.WriteLine();

    }

    public void HideRandomWords()
    {
        List<Words> visible = new List<Words>();

        foreach(Words i in _words)
        {
            if (i.IsHidden() == false)
            {
                visible.Add(i);
            }
        }
        if (visible.Count == 0)
        {
            return;
        }

        int numToHide = Math.Min(2, visible.Count);

        for (int i = 0; i < numToHide; i++)
        {
            int randIndex = _random.Next(visible.Count);
            visible[randIndex].Hide();
            visible.RemoveAt(randIndex);

        }


    }
    public Boolean AllWordsHidden()
    {
        // return true when all words are hidden
        foreach(Words i in _words)
        {
            if (i.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    public int NumLeft()
    {
        int count = 0; 
        
        foreach (Words i in _words)
        {
            if(i.IsHidden() == false)
            {
                count++;
            }
        }
        return count;
    }

}