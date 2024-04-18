using System;
namespace Aufgabe02_Time_TimeSpan_
{
	public class Time
	{
		int minutes;

		public Time(int hours, int minutes)
		{
			this.minutes = (hours * 60) + minutes;
		}

		private Time(int minutes)
		{
			this.minutes = minutes;
		}

		public static implicit operator Time(string s)
		{
			string[] timeList = s.Split(":");
			int hours = Convert.ToInt32(timeList[0]);
            int minutes = Convert.ToInt32(timeList[1]);

            return new Time(hours, minutes);
		}

		public static implicit operator Time(int k)
		{
			return new Time(k);
		}

		public static bool operator true(Time x)
		{
			return x.minutes > 0;
		}

        public static bool operator false(Time x)
        {
            return x.minutes < 0;
        }

		public static Time operator + (Time a, Time b)
		{
			return new Time(a.minutes + b.minutes);
		}

		public static TimeSpan operator - (Time a, Time b)
		{
			return new TimeSpan(a.minutes - b.minutes);
		}

		public static bool operator == (Time a, Time b)
		{
			return a.minutes == b.minutes;
		}

		public static bool operator != (Time a, Time b)
		{
			return a.minutes != b.minutes;
		}

        public override string ToString()
        {
			int hours = this.minutes / 60;
			int minutes = this.minutes % 60;

			return $"{hours}:{minutes} Uhr";
        }
    }
}

