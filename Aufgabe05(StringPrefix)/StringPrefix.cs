using System;
namespace Aufgabe05_StringPrefix_
{
    public class StringPrefix
    {

        public string FullString;
        public int PrefixLength;

        public StringPrefix(string fullString, int prefixLength)
        {
            FullString = fullString;
            PrefixLength = prefixLength;
        }

        // Overload the decrement operator (--).
        public static StringPrefix operator --(StringPrefix prefix)
        {
            if (prefix.PrefixLength > 0)
            {
                prefix.PrefixLength--;
                return prefix;
            }
            else
            {
                // If the prefix length is already zero, return an empty string.
                return new StringPrefix("", 0);
            }
        }

        // Overload the subtraction operator (-).
        public static StringPrefix operator -(StringPrefix prefix, int value)
        {
            int newPrefixLength = prefix.PrefixLength - value;
            if (newPrefixLength >= 0)
            {
                return new StringPrefix(prefix.FullString.Substring(0, newPrefixLength), newPrefixLength);
            }
            else
            {
                // If the resulting prefix length is negative, return an empty string.
                return new StringPrefix("", 0);
            }
        }

        // Overload the equality operator (==).
        public static bool operator ==(StringPrefix a, StringPrefix b)
        {
            return a.FullString == b.FullString && a.PrefixLength == b.PrefixLength;
        }

        // Overload the inequality operator (!=).
        public static bool operator !=(StringPrefix a, StringPrefix b)
        {
            return !(a == b);
        }


        // Override the ToString method to display the prefix.
        public override string ToString()
        {
            return FullString.Substring(0, PrefixLength);
        }
    }

}

