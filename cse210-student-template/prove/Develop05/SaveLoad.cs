using System;
using System.Collections.Generic;
using System.IO;

class SaveLoad
{
    public void SaveGoals(string fileName, int totalPoints, List<Goals> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goals g in goals)
            {
                outputFile.WriteLine(g.LoadGoalDetails());
            }
        }
    }
    // We pass in the list so we can add the loaded goals to it
    public int LoadFile(string loadFile, List<Goals> allGoals)
    {
        string[] readfile = System.IO.File.ReadAllLines(loadFile);

        // 1. Get the points
        int loadedPoints = int.Parse(readfile[0]);

        foreach (string line in readfile)
        {
            if (!line.Contains(":")) continue;

            // LOYALTY LOGIC: Your double-split
            string[] mainParts = line.Split(":");
            string type = mainParts[0];
            string data = mainParts[1];
            string[] dataParts = data.Split(",");

            if(type == "SimpleGoal")
            {
                Simple loadGoal = new Simple();
                loadGoal.SetDetails(dataParts[0], dataParts[1], int.Parse(dataParts[2]), bool.Parse(dataParts[3]));
                allGoals.Add(loadGoal);
            }
            else if(type == "EternalGoal")
            {
                Eternal loadGoal = new Eternal();
                loadGoal.SetDetails(dataParts[0], dataParts[1], int.Parse(dataParts[2]));
                allGoals.Add(loadGoal);
            }
            else if(type == "ChecklistGoal")
            {
                Checklist loadGoal = new Checklist();
                loadGoal.SetDetails(dataParts[0], dataParts[1], int.Parse(dataParts[2]), int.Parse(dataParts[3]), int.Parse(dataParts[4]), int.Parse(dataParts[5]));
                allGoals.Add(loadGoal);
            }
        }
        return loadedPoints; // Return this to update totalPoints in Main
    }
}