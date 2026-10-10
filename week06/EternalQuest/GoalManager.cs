using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;

        Console.WriteLine("Welcome to the Eternal Quest Program!");        
    }
    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
            }        
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice =="2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if ( choice == "3")
        {
            Console.Write("Enter the target amount: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new CheckListGoal(name, description, points, 0, target, bonus));
        }



    }

    private void ListGoals()
    {
        Console.WriteLine("Your goals: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"Current Score: {_score}");
    }

    private void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? ");

        for (int i = 0; i< _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]. GetName()}");
        }

        Console.Write("Enter the number: ");
        int index = int.Parse(Console.ReadLine()) -1;
        
        Goal goal = _goals[index];

        goal.RecordEvent();
        _score += goal.GetPoints();

        if (goal is CheckListGoal checklist && checklist.IsComplete())
        {
            _score += checklist.GetBonus();
        }

        Console.WriteLine($"Your new score is: {_score}");
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved");
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        string [ ] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i =1; i < lines.Length; i ++)
        {
            string line= lines[i];
            string [] parts = line.Split(":");
            string type = parts[0];
            string[] data = parts[1].Split("|");

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "CheckListGoal")
            {
                _goals.Add(new CheckListGoal(
                    data[0], 
                    data[1], 
                    int.Parse(data[2]),
                    int.Parse(data[3]),
                    int.Parse(data[4]),
                    int.Parse(data[5])
                ));
            }
        }
    Console.WriteLine("Goals loaded.");

    }


}