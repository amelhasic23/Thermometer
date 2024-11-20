using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite temperaturu u Farenhajtima:");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = F2C(fahrenheit);

        Console.WriteLine($"Temperatura u Celzijusima: {celsius}");
    }

    static double F2C(double f)
    {
        return (f - 32) * 5 / 9;
    }
}
