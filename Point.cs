using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEquationCalculator
{
    public class Point
    {
        public Point(float x, float y)
        {
            X = (float)Math.Round(x, 4);
            Y = (float)Math.Round(y, 4);
        }

        public float X { get; private set; }
        public float Y { get; private set; }

        public override bool Equals(object obj)
        {
            Point objPoint = obj as Point;

            if (objPoint == null)
                return false;

            return X == objPoint.X && Y == objPoint.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
