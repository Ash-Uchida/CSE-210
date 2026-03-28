using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Console.WriteLine("This is Abstraction with Youtube Videos\n");

        Video vid1 = new Video("Iron Lung review", "Markiplier",20);
        Comment com1 = new Comment("Kitty123", "An absolute banger movie");
        Comment com2 = new Comment("movieLover", "I loved the movie");
        Comment com3 = new Comment("movieHater", "not a fan");
        // Add the comment to the video
        vid1.AddComment(com1);
        vid1.AddComment(com2);
        vid1.AddComment(com3);
        //Add the video to my vid list
        _videos.Add(vid1);



        //lets make another example
        Video vid2 = new Video("BlackPink behind the scenes", "Jennie",40);
        Comment v2com1 = new Comment("JennieStan262267","I LOVE JENNIE, SHE'S MY BIAS");
        Comment v2com2 = new Comment("LISAlover444","Jennie is nice but I stan Lisa!!!!");
        //then adding 
        vid2.AddComment(v2com1);
        vid2.AddComment(v2com2);
        //then add to list
        _videos.Add(vid2);


        //foreach vid in list display its info
        foreach (Video v in _videos)
        {
            Console.WriteLine($"Title: {v._title} | Author: {v._author} | Length: {v._length}min");
            Console.WriteLine($"Number of comments: {v.GetCommentCount()}");
            
            v.DisplayVidStuff(); 
        }

    }
}