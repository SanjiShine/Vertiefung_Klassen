namespace Aufgabe05_StringPrefix_;

class Program
{
    public static void Main()
    {
        // Erzeugung eines neuen Präfix-Strings mit Präfixlänge 10:
        StringPrefix stringPrefix1 = new StringPrefix("I like C#!?", 10);
        Console.WriteLine("1. " + stringPrefix1);
        stringPrefix1--; // Präfixlänge wird um 1 reduziert
        Console.WriteLine("2. " + stringPrefix1--); // Präfixlänge wird um eins reduziert
        stringPrefix1 -= 2; // Präfixlänge wird um 2 reduziert
        Console.WriteLine("3. " + stringPrefix1);
        Console.WriteLine("4. " + (stringPrefix1 - 5)); // Mit reduzierter Präfixlänge um 5
        Console.WriteLine("5. " + stringPrefix1);

        StringPrefix stringPrefix2 = new StringPrefix("I like C++!", 11); // Analog zu oben

        // Vergleich, ob beide String-Präfixe gleich sind:
        if (stringPrefix1 == stringPrefix2)
            Console.WriteLine("6. IMPOSSIBLE!");
        // Vergleich, ob beide String-Präfixe gleich sind, inklusive einer reduzierten Präfixlänge um 5:
        if (stringPrefix1 == stringPrefix2 - 5)
            Console.WriteLine("6. HAPPY END.");
    }
}

