using System.Collections.Generic;

namespace MarsRoverKata
{
    public class RoverPosition
    {
        public int X { get; }
        public int Y { get; }
        public char Direction { get; }

        public RoverPosition(int x, int y, char direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public override bool Equals(object obj)
        {
            var position = obj as RoverPosition;
            return position != null &&
                   X == position.X &&
                   Y == position.Y &&
                   Direction == position.Direction;
        }

        public override int GetHashCode()
        {
            var hashCode = 1889109973;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + Direction.GetHashCode();
            return hashCode;
        }
    }
}