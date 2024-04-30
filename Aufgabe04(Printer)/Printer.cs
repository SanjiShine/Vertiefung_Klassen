using System;
namespace Aufgabe04_Printer_
{
    class Printer
    {
        private char printCharacter;
        private string output = "";
        public Printer(char printCharacter)
        {
            this.printCharacter = printCharacter;
        }
        private void PrintOneCharacter()
        {
            output += printCharacter;
        }
        public static Printer operator ++(Printer printer)
        {
            printer.PrintOneCharacter();
            return printer;
        }
        public static Printer operator +(Printer printer, int addierteZahl)
        {
            for (int i = 0; i < addierteZahl; i++)
            {
                printer.PrintOneCharacter();
            }
            return printer;
        }
        public static Printer operator <<(Printer printer, char newChar)
        {
            printer.printCharacter = newChar;
            return printer;
        }
        // Overload the greater-than operator (>), to compare the number of printed characters
        public static bool operator >(Printer printer1, Printer printer2)
        {
            // Assumption: Number of printed characters is equal to the length of the output string
            return printer1.output.Length > printer2.output.Length;
        }
        // Overload the less-than operator (<), to compare the number of printed characters
        public static bool operator <(Printer printer1, Printer printer2)
        {
            // Assumption: Number of printed characters is equal to the length of the output string
            return printer1.output.Length < printer2.output.Length;
        }
        // Overload the explicit cast to string
        public static explicit operator string(Printer printer)
        {
            return printer.output;
        }

    }
}

