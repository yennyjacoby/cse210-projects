using System;
using System.Runtime.InteropServices;

public class BreathingActivity:Activity

//constructor that calls the Base!
{
    public BreathingActivity()
    
        : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {     
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in... ");
            ShowBreathingAnimation();
            Console.WriteLine("Now, breath out... ");
            ShowBreathingAnimation();
        }
        DisplayEndingMessage();
    }

    public void ShowBreathingAnimation()
    {
        // Inhaling
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(new string('.', i));
            Thread.Sleep(300);
        }

        // Exhaling
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(new string('.', i));
            Thread.Sleep(300);
        }
    }

}