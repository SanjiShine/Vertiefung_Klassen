using System;
namespace Aufgabe01_Duration_
{
	public class Duration
	{
		public int Days { get; set; }
		public int Hours { get; set; }
		public int Minutes { get; set; }

		public Duration(int days, int hours, int minutes)
		{
            int totalMinutes = days * 24 * 60 + hours * 60 + minutes;

            this.Days = ((totalMinutes / 24) / 60);
            this.Minutes = totalMinutes % 60;
            this.Hours = (totalMinutes - ((this.Days * 24 * 60) + this.Minutes)) / 60;
		}

        public override string ToString()
        {
			return $"Es dauert: {this.Days} Tage, {this.Hours} Stunden und {this.Minutes} Minuten.";
        }

        public static Duration operator + (Duration x, Duration y)
        {
            int totalMinutes = TimeToMinutes(x) + TimeToMinutes(y);

            return MinutesToTime(totalMinutes);
        }

        public static Duration operator - (Duration x, Duration y)
        {
            int timeX = TimeToMinutes(x);
            int timeY = TimeToMinutes(y);
            
            if(timeX > timeY) {

                return MinutesToTime(timeX - timeY);
        
            }else {
                return MinutesToTime(timeY - timeX);
            }
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
            return (x.Days * 24 * 60 + x.Hours * 60 + x.Minutes) * 60;
        }

        public static int TimeToMinutes(Duration x)
        {
            return  x.Days * 24 * 60 + x.Hours * 60 + x.Minutes;
        }

        public static Duration MinutesToTime(int minutes)
        {
            int days = (minutes / 24) / 60;
            int min = minutes % 60;
            int hours = (minutes - ((days * 24 * 60) + min))/60;

            return new Duration(days, hours, min);
        }

    }
}