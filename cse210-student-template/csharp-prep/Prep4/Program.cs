using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> nums= new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.!");
        int new_num = int.Parse(Console.ReadLine());
        nums.Add(new_num);
        while (new_num != 0)
        {
            Console.WriteLine(" Enter number: ");        
            new_num = int.Parse(Console.ReadLine());
            if (new_num != 0)
            {
               nums.Add(new_num); 
            }
            
        }

        if (nums.Count > 0)
        {    
            int sum = 0;
            double avg = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine($"The sum is: {sum}");

            avg = (double)sum / nums.Count;
            Console.WriteLine($"The average is {avg}"); 
        }

        // now for the largest num
        int big = nums[0];

        foreach(int i in nums)
        {
            if (i > big)
            {
                big = i;
            }
        }
        Console.WriteLine($"The largest number is: {big} ");

    }
}