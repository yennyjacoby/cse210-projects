using System;
using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    //CONSTRUCTORS
//constructor should only set things that are always known in ADVANCE. That's why _duration should not be here. 
    public Activity(string name, string description)
    {
        _name= name;
        _description = description;
    }

    //SHARED Methods
 

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} 🌱  ");
        Console.WriteLine(_description);
        Console.WriteLine("\nHow long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Write("Get Ready ");
        ShowSpinner(3);        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}");
        ShowSpinner(5);
        
    }

    public void ShowSpinner(int seconds)
    {
        string[] frames = { "/", "-", "\\", "|" };

        for (int i = 0; i < seconds * 2; i++) 
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(400); 
            Console.Write("\b"); // erase the last character
        }

        Console.WriteLine();

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i> 0; i--)
        {
            Console.Write(i+ " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

    }
}
