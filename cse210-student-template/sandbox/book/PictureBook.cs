using System;

namespace library_demo
{
    public class PictureBook : Book
    {
        private string _illistrator = "";

        // constructor
        public PictureBook(string author, string title, string illistrator) : base (author, title)
        {
            _illistrator = illistrator;
        }

        
        public string Getillistrator()
        {
            return _illistrator;
        }
        public void Setillistrator(string illistrator)
        {
            _illistrator = illistrator;
        }

        public string GetPictureBookInfo()
        {
            return $"{_title} by {_author} illistrated by {_illistrator}";
        }
    }
}