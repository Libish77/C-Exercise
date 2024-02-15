using System;

class Interval
{
    static void Main()
    {
        Console.Write("Enter a real number: ");
        double x = double.Parse(Console.ReadLine());

        bool belongsToI = (x >= 2 && x < 3) || (x >= 0 && x <= 1) || (x >= -10 && x <= -2);

        if (belongsToI)
        {
            Console.WriteLine($"x belongs to I");
        }
        else
        {
            Console.WriteLine($"x does not belong to I");
        }
    }
}