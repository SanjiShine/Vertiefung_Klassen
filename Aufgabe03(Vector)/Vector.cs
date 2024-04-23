using System;
namespace Aufgabe03_Vector_
{
	public class Vector
	{
		float x;
		float y;

		public Vector(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public static Vector operator + (Vector a, Vector b)
		{
			return new Vector(a.x + b.x, a.y + b.y);
		}

		public static Vector operator * (Vector a, float n)
		{
			return new Vector(a.x * n, a.y * n);
		}

		public static Vector operator ++ (Vector a)
		{
			a.x += a.x;
			a.y += a.y;

			return a;
		}

		public static Vector operator - (Vector a)
		{
			return new Vector(-a.x, -a.y);
		}

		public static bool operator == (Vector a, Vector b)
		{
			return a.x == b.x && a.y == b.y;
		}

        public static bool operator != (Vector a, Vector b)
        {
            return a.x != b.x || a.y != b.y;
        }

		public static explicit operator float(Vector a)
		{
			return (float)Math.Sqrt(a.x * a.x + a.y * a.y);

        }

		public override string ToString()
        {
			return $"({this.x},{this.y})";
        }
    }
}

