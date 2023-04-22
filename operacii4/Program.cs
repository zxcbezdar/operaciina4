using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите значение b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите значение c: ");
        double c = double.Parse(Console.ReadLine());

        double otvet = ((Math.Pow(a, 2) - 4 * b * c) / (a - Math.Sqrt(a) - Math.Pow(a, c)) - Math.Pow(a * b * c, 3)) / (Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2)); ;
        Console.WriteLine($"Формула : ((a²-4bc)/(a - a¹/²-a^c)-(abc)³)/(a²-2ab+b²) = {otvet} при a={a}, b={b}, c={c}");
    }
}
