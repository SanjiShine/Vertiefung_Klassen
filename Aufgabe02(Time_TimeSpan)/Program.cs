namespace Aufgabe02_Time_TimeSpan_;

class Program
{
    static void Main(string[] args)
    {
        Time t1 = new Time(9, 45);
        Time t2 = t1 + "1:30" + 15; // "11:30"
        Time t3 = "11:30";
        TimeSpan tDiff = t2 - t1;
        Console.WriteLine($"t1: {t1}"); //out: t1: 9:45 Uhr
        Console.WriteLine($"t2: {t2}"); //out: t2: 11:30 Uhr
        Console.WriteLine($"tDiff: {tDiff}"); //out: tDiff: 1h45min
        Console.WriteLine($"tDiff in Min: {tDiff.TotalMins}");
        //out: tDiff in Min: 105
        if (t2) //out: Guten Morgen
            Console.WriteLine("Guten Morgen");
        else
            Console.WriteLine("Guten Tag");
        if (t2 == t3) //out: Die Uhrzeiten sind gleich!
            Console.WriteLine("Die Uhrzeiten sind gleich!");
        else
            Console.WriteLine("Die Uhrzeiten stimmen nicht überein!");
    }
}

