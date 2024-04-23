namespace Aufgabe03_Vector_;

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(1, 1);
        Vector v2 = new Vector(1, 1);

        Console.WriteLine(1.0f * (float)v1);
        Console.WriteLine(-(v1 + v1 * 5.0f + ++v1));
        Console.WriteLine(new Vector(1, 1) + ++v2 * 10 + v2++);
        Console.WriteLine(v2);
        Console.WriteLine(v1);
        Console.WriteLine(v1 == v2 ? "ja" : "nein");
        Console.WriteLine(new Vector(1, 1) != new Vector(1, 1) ? "ja" : "nein");


    }
}

