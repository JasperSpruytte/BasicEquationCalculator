using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEquationCalculator
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public override bool Equals(object obj)
        {
            Point objPoint = obj as Point;

            if (objPoint == null)
                return false;

            return X == objPoint.X && Y == objPoint.Y;
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }
    }
}
