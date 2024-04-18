using System;
namespace Aufgabe01_Duration_
{
	public class Duration
	{
		public int days { get; set; }
		public int hours { get; set; }
		public int minutes { get; set; }

		public Duration(int days, int hours, int minutes)
		{
			this.days = days;
			this.hours = hours;
			this.minutes = minutes;
		}

        public override string ToString()
        {
			return $"Es dauert: {this.days} Tage, {this.hours} Stunden und {this.minutes} Minuten.";
        }

        public static Duration operator + (Duration x, Duration y)
        {
            return new Duration(x.days + y.days, x.hours + y.hours, x.minutes + y.minutes);
        }

        public static Duration operator - (Duration x, Duration y)
        {
            return new Duration(x.days - y.days, x.hours - y.hours, x.minutes - y.minutes);
        }

        public static bool operator < (Duration x, Duration y)
        {
            return (int)x < (int)y;
        }

        public static bool operator > (Duration x, Duration y)
        {
            return (int)x > (int)y;
        }

        public static bool operator <= (Duration x, Duration y)
        {
            return (int)x <= (int)y;
        }

        public static bool operator >= (Duration x, Duration y)
        {
            return (int)x >= (int)y;
        }

        public static explicit operator int (Duration x)
        {
            return (x.days * 24 * 60 + x.hours * 60 + x.minutes) * 60;
        }


    }
}