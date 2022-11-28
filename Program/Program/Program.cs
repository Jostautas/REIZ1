namespace Program;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Clock Angle App");

        Clock c = new();
        c.GetInput();
        c.PrintTime();

        double angle = c.GetAngle();
        if(angle == -1)
        {
            Console.WriteLine("ERROR: unable to calculate angle");
        }
        else
        {
            Console.WriteLine("The angle of clock arms is " + angle + " degrees");
        }
    }
}