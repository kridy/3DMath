using System;

namespace _3dMath
{
    public class Vector2 
    {
        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return a.Add(b);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return a.Subtract(b);;
        }
        public static Vector2 operator *(Vector2 a, double i)
        {
            return a.Multiply(i);
        }
        public static Vector2 operator *(double a, Vector2 i)
        {
            return i.Multiply(a);
        }
        public static bool operator ==(Vector2 a, Vector2 b)
        {
            if (ReferenceEquals(a, b)) return true;

            if (((object) a == null) || ((object) b == null)) return false;

            return (a.X == b.X) && (a.Y == b.Y);
        }
        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return !(a == b);
        }

        public Vector2 Add(Vector2 v)
        {
            return new Vector2(X + v.X, Y + v.Y);
        }
        public Vector2 Subtract(Vector2 v)
        {
            return new Vector2(X - v.X, Y - v.Y);
        }
        public Vector2 Multiply(double scalar)
        {
            return new Vector2(X * scalar, Y * scalar);
        }

        public double Magnitude
        {
            get { return Math.Abs(Math.Sqrt((X * X) + (Y * Y))); }
        }

        public double Normalized {
            get { return 1 / Magnitude; }
        }

        public bool Equals(Vector2 vector)
        {
            if ((object) vector == null) return false;

            return (X == vector.X) && (Y == vector.Y);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            var v = obj as Vector2;
            if ((object) v == null) return false;

            return (X == v.X) && (Y == v.Y);
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", X, Y);
        }
    }   

}