using System;

class Program
{
    static void Main()
    {
        Console.Write("xp = ");
        double xp = Convert.ToDouble(Console.ReadLine());

        Console.Write("xk = ");
        double xk = Convert.ToDouble(Console.ReadLine());

        Console.Write("dx = ");
        double dx = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("---------------------------");
        Console.WriteLine("|    x    |       y       |");
        Console.WriteLine("---------------------------");

        double x = xp;
        while (x <= xk)
        {
            double A = 1.0 / Math.Abs(x + 2) + 1;
            double B;

            if (x < 1)
            {
                B = 7 * x * x + x - 8;
            }
            else if (x >= 1 && x <= 4)
            {
                B = 1 / Math.Tan((x + 4) / Math.Sqrt(11)) + 3;
            }
            else
            {
                B = Math.Sqrt(1 + Math.Abs(Math.Cos(x)));
            }

            double y = A + B;
            Console.WriteLine($"|  {x,7:F2}  |  {y,10:F3}  |");
            x += dx;
        }

        Console.WriteLine("---------------------------");
    }
}
