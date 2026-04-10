using System;

public class F_kwadratowa
{
    private double a, b, c;

    public F_kwadratowa(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Delta()
    {
        return b * b - 4 * a * c;
    }

    public (double x1, double x2) Rozwiaz()
    {
        if (a == 0)
        {
            return (double.NaN, double.NaN);
        }

        double d = Delta();

        if (d > 0)
        {
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            return (x1, x2);
        }
        else if (d == 0)
        {
            double x0 = -b / (2 * a);
            return (x0, double.NaN);
        }
        else
        {
            return (double.NaN, double.NaN);
        }
    }
}

class f_kwadratowa
{
    static void Main()
    {
        F_kwadratowa fk = new F_kwadratowa(1, -3, 2);

        var wynik = fk.Rozwiaz();
        Console.WriteLine($"Wynik: {wynik.x1}, {wynik.x2}");
    }
}
