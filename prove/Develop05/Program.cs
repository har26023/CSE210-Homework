using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        int totalPoints = 0;
        int streak = 0;
        List<Goal> goals = new List<Goal>();

        do
        {
            Console.WriteLine($"\nYou have {totalPoints} points. | Current Streak: {streak}\n");
            Console.Write("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\nSelect a choice from the menu: ");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Write("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create?: ");
                    int goalNum = int.Parse(Console.ReadLine());
                    string tempTitle;
                    string tempDescription;
                    int tempPoints;
                    switch (goalNum)
                    {
                        case 1:
                            Console.Write("\nWhat is the name of your goal?: ");
                            tempTitle = Console.ReadLine();
                            Console.Write("What is a short description of it?: ");
                            tempDescription = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal?: ");
                            tempPoints = int.Parse(Console.ReadLine());
                            SimpleGoal simple = new SimpleGoal(tempTitle,tempDescription,tempPoints);
                            goals.Add(simple);
                            break;
                        case 2:
                            Console.Write("\nWhat is the name of your goal?: ");
                            tempTitle = Console.ReadLine();
                            Console.Write("What is a short description of it?: ");
                            tempDescription = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal?: ");
                            tempPoints = int.Parse(Console.ReadLine());
                            EternalGoal eternal = new EternalGoal(tempTitle,tempDescription,tempPoints);
                            goals.Add(eternal);
                            break;
                        case 3:
                            Console.Write("\nWhat is the name of your goal?: ");
                            tempTitle = Console.ReadLine();
                            Console.Write("What is a short description of it?: ");
                            tempDescription = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal?: ");
                            tempPoints = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
                            int tempGoal = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times?: ");
                            int tempBonusPoints = int.Parse(Console.ReadLine());
                            Checklist check = new Checklist(tempTitle,tempDescription,tempPoints,0,tempGoal,tempBonusPoints);
                            goals.Add(check);
                            break;
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("\nThe goals are:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.Write($"{i + 1}. ");
                        goals[i].Display();
                    }
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string saveFileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(saveFileName))
                    {
                        outputFile.WriteLine(totalPoints);
                        outputFile.WriteLine(streak);

                        foreach (Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.GetSaveString());
                        }
                    }
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file?: ");
                    string loadFileName = Console.ReadLine();
                    string[] lines = File.ReadAllLines(loadFileName);
                    totalPoints = int.Parse(lines[0]);
                    streak = int.Parse(lines[1]);
                    goals.Clear();
                    for (int i = 2; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(':');
                        string goalType = parts[0];
                        string[] data = parts[1].Split('|');
                        if (goalType == "SimpleGoal")
                        {
                            SimpleGoal simple = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                            if (bool.Parse(data[3]))
                            {
                                simple.SetComplete();
                            }
                            goals.Add(simple);
                        }
                        else if (goalType == "EternalGoal")
                        {
                            EternalGoal eternal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                            goals.Add(eternal);
                        }
                        else if (goalType == "Checklist")
                        {
                            Checklist check = new Checklist(
                                data[0],
                                data[1],
                                int.Parse(data[2]),
                                int.Parse(data[3]),
                                int.Parse(data[4]),
                                int.Parse(data[5])
                            );
                            if (int.Parse(data[3]) >= int.Parse(data[4]))
                            {
                                check.SetComplete();
                            }
                            goals.Add(check);
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("\nThe goals are:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].GetTitle()}");
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int choice = int.Parse(Console.ReadLine()) - 1;
                    Goal selectedGoal = goals[choice];
                    int pointsEarned = selectedGoal.GetPoints();
                    if (selectedGoal is SimpleGoal)
                    {
                        selectedGoal.SetComplete();
                    }
                    else if (selectedGoal is Checklist checklist)
                    {
                        checklist.IncreaseTimesDone();
                        if (checklist.IsDone())
                        {
                            checklist.SetComplete();
                            pointsEarned += checklist.GetBonusPoints();
                        }
                    }
                    streak++;
                    if (streak >= 3)
                    {
                        int bonus = (int)(pointsEarned * 0.2);
                        pointsEarned += bonus;
                        Console.WriteLine($"Streak Bonus ({streak} in a row): +{bonus} extra points!");
                    }
                    totalPoints += pointsEarned;
                    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                    Console.WriteLine($"You now have {totalPoints} points.");
                    break;
                case 6:
                    break;    
                default:
                    Console.WriteLine("That input was not valid, please try again.");
                    break;
            }
        }
        while(input != 6);
    }
}