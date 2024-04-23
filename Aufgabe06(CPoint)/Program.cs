namespace Aufgabe06_CPoint_;

class Program
{
    static void Main(string[] args)
    {
        CPoint p1 = new CPoint(10, 10);
        CPoint p2 = p1 * 2; // Skalarprodukt (alle Komponenten werden mit dem Faktor multipliziert
        CPoint p3 = p2 - p1; // Differenz zweier Vektoren
        double d = (double)p3; // Vektorlänge (mittels Konvertierung nach double)
        if((p2 - p1) == p1) Console.WriteLine("Punkte sind gleich!");
        Console.WriteLine(p2 * 3 - p3);
        Console.WriteLine(d);
    }
}

