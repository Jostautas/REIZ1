﻿namespace Program;

public class Clock
{
    private int Hours { get; set; }
    private int Minutes { get; set; }

    public Clock()
    {
    }

    public void GetInput()
    {
        Console.WriteLine("Valid input: 0 <= Hours <= 12 | 0 <= Minutes <= 720");

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
        int hourAngle = GetHourAngle();
        double minuteAngle = GetMinuteAngle();

        double angle = Math.Abs(hourAngle - minuteAngle);

        if(angle > 180)
        {
            angle = 360 - angle;
        }

        return angle;
    }

    private int GetHourAngle()
    {
        if(Hours == 0 || Hours == 12)
        {
            return 0;
        }
        else
        {
            return Hours * 30;      // 360 / 12 = 30
        }
    }

    private double GetMinuteAngle()
    {
        if (Minutes == 0 || Minutes == 720)
        {
            return 0;
        }
        else
        {
            return Minutes * 0.5;      // 30 / 60 = 1/2
        }
    }
}
