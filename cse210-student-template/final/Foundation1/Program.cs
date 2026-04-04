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
        Comment v2com3 = new Comment("foreverRose88","I love both jennie and lisa but I'm forever a rose fan!");
        Comment v2com4 = new Comment("foreverJennie0w0","I love jennie so much I learned the choreo for her latest song!");
        //then adding 
        vid2.AddComment(v2com1);
        vid2.AddComment(v2com2);
        vid2.AddComment(v2com3);
        vid2.AddComment(v2com4);
        //then add to list
        _videos.Add(vid2);



        //another example
        Video vid3 = new Video("LiveStreamInChina","IShowSpped",70);
        Comment v3com1 = new Comment("iFollowYou","No way! your in china now! i live there bro!");
        Comment v3com2 = new Comment("truthKing27238278","Bro if you live in china why is you comment in english?");
        Comment v3com3 = new Comment("iFollowYou","Nah dog why you calling me out! fr not chill dude");
        vid3.AddComment(v3com1);
        vid3.AddComment(v3com2);
        vid3.AddComment(v3com3);
        _videos.Add(vid3);


        //foreach vid in list display its info
        foreach (Video v in _videos)
        {
            Animation.CountDown(3);
            

            Console.WriteLine($"\nTitle: {v._title} | Author: {v._author} | Length: {v._length}min");
            Console.WriteLine($"Number of comments: {v.GetCommentCount()}");
            
            v.DisplayVidStuff(); 
        }

    }
}