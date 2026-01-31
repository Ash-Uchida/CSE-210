// this is where we store the entries
// you want to intilaize this class
using System.Data;
using System.Collections.Generic;

public class Journal
{
    // we always start with attributes then end this file with methods
    public List<string> _prompts = new List<string> { "What was the single best 60 seconds of my day, and why?", "Which conversation or task today gave me energy, and which one drained it?", "What is one small thing I did today that my 'tomorrow self' will thank me for?", "If I could go back and say one thing I kept to myself today, what would it be?", "What is one thing I saw or heard today that I want to learn more about?", "Was there a specific moment where my mood shifted? What triggered it?", "What is a 'micro-victory' I had today that nobody else noticed?", "What is one nagging thought from today that I’m choosing not to carry into tomorrow?", "If I had to describe today using only a smell, a taste, and a sound, what would they be?", "If today was a chapter in a book, what would the title be?" };
    public List<Entry> _entrys = new List<Entry>();
    public List<string> _quotes = new List<string> {"Keep your face to the sunshine and you cannot see a shadow.","Everything is funny, as long as it is happening to somebody else.", "Don’t sweat the petty things and don’t pet the sweaty things.", "Life is short. Smile while you still have teeth.", "Normality is a paved road: It’s comfortable to walk, but no flowers grow.", "Bloom where you are planted.", "Even the smallest feline is a masterpiece.", "Be a cupcake in a world of muffins.", "Wherever you go, go with all your heart.", "The most wasted of all days is one without laughter.", "Do anything, but let it produce joy.", "To be yourself in a world that is constantly trying to make you something else is the greatest accomplishment.", "Kindness is like snow—it beautifies everything it covers.", "If you have good thoughts, they will shine out of your face like sunbeams.", "Happiness is a warm puppy."};
    public string RandomPrompt()
    {
        Random randomGenerator = new();
        int randPrompt = randomGenerator.Next(0, _prompts.Count);
        return _prompts[randPrompt];
    }
    public string RandomQuote()
    {
        Random randomGenerator = new();
        int randomQuote = randomGenerator.Next(0, _quotes.Count);
        return _quotes[randomQuote];
    }
    public void addEntry(string prompt, string userText, DateTime timeNow)
    {
        Entry store = new Entry();
        store._entry = userText;
        store._prompt = prompt;
        store._date = timeNow;
        _entrys.Add(store);

    }
    public void Display()
    {
        foreach (var item in _entrys)
        {
            item.Display();
        }

    }

    public string Input()
    {
        string txtInput= "";
        // write another method in entry
        foreach (var item in _entrys)
        {
            string date = item._date.ToString("M/d/yyyy h:mm:ss tt");
            txtInput += $"Date: {date} \n Prompt: {item._prompt} \n {item._entry} \n \n";

        }
        return txtInput;

    }


}
