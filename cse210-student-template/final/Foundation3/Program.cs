using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _events = new List<Event>();

        Console.WriteLine("Inheritance with Event Planning \n\n");

        // we got a list of address to use
        Address add1 = new Address("576 Sunny Spruce Street, Silver Springs");
        Address add2 = new Address("878 Breezy Birch Boulevard, Blue Bay");
        Address add3 = new Address("2543 Misty Maple Manor, Mountain Meadows");
        Address add4 = new Address("77 Coral Cove Court, Crystal City");

        //lets create an event for each class
        Lectures lec1 = new Lectures("Community Leadership Talk", "A discussion on leadership principles and how to create a positive impact within your community.","April 15, 2026", "10:30AM", add1, "Alex Anderson", 150);
        Receptions rep1 = new Receptions("Midnight Masquerade Mixer", "An elegant evening of masks, music, and mystery. Dress to impress and enjoy light refreshments.", "October 31, 2026", "8:00 PM", add2,true,"masquerade@midnightmail.com");
        Outdoors out1 = new Outdoors("Mountain Morning Meetup", "Start your day with a refreshing hike and scenic views. Great for all skill levels!", "June 10, 2026", "7:30 AM", add3);

        // adding the events to the events list then we loop through it and display it
        _events.Add(lec1);
        _events.Add(rep1);
        _events.Add(out1);

        // Then, use a foreach loop to iterate through the list and call StandardDetails(), FullDetails(), and ShortDesc() for each.
        foreach(Event e in _events)
        {
            Console.WriteLine($"{e.StandardDetails()} \n-----------------------\n {e.FullDetails()}\n-----------------------\n{e.ShortDesc()}\n-----------------------\n");

        }
    }
}