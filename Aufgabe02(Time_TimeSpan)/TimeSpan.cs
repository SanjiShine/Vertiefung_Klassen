using System;
namespace Aufgabe02_Time_TimeSpan_
{
	public class TimeSpan
	{
		int _minutes;

		public int TotalMins
		{
			get { return _minutes; }
		}

		public TimeSpan(int minutes)
		{
			this._minutes = minutes;
		}

        public override string ToString()
        {
			int hours = this._minutes / 60;
			int minutes = this._minutes % 60;

			return $"{hours}h{minutes}min";
        }

    }
}

