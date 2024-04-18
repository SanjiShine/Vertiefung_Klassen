namespace Aufgabe01_Duration_;

class Program
{
    static void Main(string[] args)
    {
        Duration d1 = new Duration(1, 2, 3);
        Console.WriteLine($"{ d1} Das ist gleich {(int)d1} Sekunden");

        Duration d2 = new Duration(2, 3, 4);
        Console.WriteLine(d1 + d2);
        Console.WriteLine(d2 - d1);

        Console.WriteLine(d1 < d2);
        Console.WriteLine(d1 > d2);

        Duration d3 = new Duration(2, 3, 4);

        Console.WriteLine(d2 <= d3);
        Console.WriteLine(d2 >= d3);
    }
}

