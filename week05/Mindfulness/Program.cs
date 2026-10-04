//Showing Creativity and Exceeding Requirements.
//Added a different animation for the breathing activity.

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity ");
            Console.WriteLine("3. Start listing activity ");
            Console.WriteLine("4. Quit ");
            Console.WriteLine("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice =="1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }

            if (choice =="2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }            
            
            if (choice =="3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }            
            
            if (choice =="4")
            {
                break;
            }            
        }
    }
}