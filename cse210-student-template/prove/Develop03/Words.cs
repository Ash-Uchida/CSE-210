// this will also keep track of what words we have for extra credit

public class Words
{
    private string _text;
    private bool _isHidden;

    // don't forget a constuctor
    public Words(string text)
    {
        _text = text;
        _isHidden = false; 
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public string GetDisplayText()
    {
        // "----" if hidden
        if (_isHidden)
        {
            return "----";
        }
        // _text if not hidden
        else
        {
            return _text;
        }        
        
    }
    public Boolean IsHidden()
    {
        return _isHidden;
    }
    
}