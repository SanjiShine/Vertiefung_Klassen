using System;
namespace Aufgabe06_CPoint_
{
	public class CPoint
	{
		double x, y;

		public CPoint(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public static CPoint operator * (CPoint a, int b)
		{
			return new CPoint(a.x * b, a.y * b);
		}

		public static CPoint operator - (CPoint a, CPoint b)
		{
			return new CPoint(a.x - b.x, a.y - b.y);
		}

		public static bool operator == (CPoint a, CPoint b)
		{
			return a.x == b.x && a.y == b.y;
		}

		public static bool operator != (CPoint a, CPoint b)
		{
			return a.x != b.x || a.y != b.y;
        }

		public static explicit operator double (CPoint x)
		{ 
			return Math.Sqrt(Math.Pow(x.x, 2) + Math.Pow(x.y, 2));	
		}

        public override string ToString()
        {
			return $"({x},{y})";
        }
    }
}

