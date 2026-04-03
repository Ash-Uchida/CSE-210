using System;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> _activitys = new List<Activity>();

        Console.WriteLine("Polymorphism with Exercise Tracking \n");

        // string date, double length min, double speed km/h)
        Bike bike1 = new Bike("Friday 13, 2021", 30.5,6.6);
        _activitys.Add(bike1);

        // string date, double length min, double distance
        Run run1 = new Run("June 17, 2022",40.2,2.2);
        _activitys.Add(run1);
        
        // string date, double length min, double laps)
        Swim swim1 = new Swim("August 21", 14.4, 3);
        _activitys.Add(swim1);

        foreach(Activity activity in _activitys)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
    
}