using System;

namespace library_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetAuthor("Smith");
            book1.SetTitle("Great book");
            Console.WriteLine(book1.GetBookInfo());

            PictureBook book2 = new PictureBook();
            book2.SetAuthor("Jones");
            book2.SetTitle("Wonderful picture book");
            book2.Setillistrator("Burton");
            Console.WriteLine(book2.GetPictureBookInfo());

            Book book3 = new Book();
            book3.SetTitle("no author book");
            Console.WriteLine(book3.GetBookInfo());

            // by using the second constructor we can do this
            Book book4 = new Book("Edward", "Another Book");

            // by adding the constuctor to the picturebook we can do this
            PictureBook book5 = new PictureBook("Edward", "Another Book", "Cullen");
        }
    }
}