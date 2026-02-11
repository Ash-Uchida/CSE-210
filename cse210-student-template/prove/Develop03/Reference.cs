// controls this formatting:
// Book: Proverbs
// Chapter: 3
// verse: 5
public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;

    // the constructor
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetDisplayText(){
        // this should return ->Proverbs 3:5
        return $"{_book} {_chapter}:{_verse}";
    }   


}