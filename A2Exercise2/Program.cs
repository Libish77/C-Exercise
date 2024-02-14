using System;

class Program
{
    static void Main(string[] args)
    {
        double[] testValues = { -20, -10, -2, -1, 0, 1, 1.5, 2, 3, 4 };

        foreach (double value in testValues)
        {
            Console.Write($"Enter a real number: {value} ");
            if (IsInInterval(value))
                Console.WriteLine("x belongs to I");
            else
                Console.WriteLine("x does not belong to I");
        }
    }

    static bool IsInInterval(double x)
    {
        // Define the intervals
        double[] interval1 = { 2, 3 };
        double[] interval2 = { 0, 1 };
        double[] interval3 = { -10, -2 };

        // Check if x belongs to any of the intervals
        return (x >= interval1[0] && x < interval1[1]) ||
               (x >= interval2[0] && x <= interval2[1]) ||
               (x >= interval3[0] && x <= interval3[1]);
    }
}
