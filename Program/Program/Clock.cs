using System;

namespace Program;

public class Clock
{
    private int Hours { get; set; }
    private int Minutes { get; set; }

    public Clock()
    {
    }

    public void GetInput()
    {
        Console.WriteLine("Enter Hours:");
        Hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Minutes:");
        Minutes = Convert.ToInt32(Console.ReadLine());
    }

    public void PrintTime()
    {
        Console.WriteLine("Entered time: " + Hours + ":" + Minutes);
    }

    public double GetAngle()
    {

        return -1;
    }
}
