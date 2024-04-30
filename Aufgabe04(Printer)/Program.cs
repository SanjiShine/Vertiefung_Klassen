namespace Aufgabe04_Printer_;

class Program
{
    static void Main(string[] args)
    {
        // Erzeugen eines #-Druckers 
        Printer printer1 = new Printer('#');
        // Drucken eines #-Zeichens 
        printer1++;
        Console.WriteLine("1. " + (string)printer1);
        // Drucken von 3 weiteren #-Zeichen 
        printer1 += 3;
        Console.WriteLine("2. " + (string)printer1);

        // Wechseln des Druck-Zeichens (von '#' zu 'X') und Drucken von 2 
        //weiteren X-Zeichen
        printer1 = printer1 << 'X';
        printer1 = printer1 + 2;
        Console.WriteLine("3. " + (string)printer1);

        // Erzeugen eines O-Druckers und Drucken von 5 Zeichen 
        Printer printer2 = new Printer('O') + 5;
        Console.WriteLine("4. " + (string)printer2);

        // Vergleich der zwei gedruckten Längen (= Anzahl der Zeichen in der Ausgabe) 
        if (printer1 > printer2)
            Console.WriteLine("5. Der 1. Drucker hat mehr Zeichen gedruckt.");
        else
            Console.WriteLine("5. Der 2. Drucker hat mehr Zeichen gedruckt.");

    }
}

