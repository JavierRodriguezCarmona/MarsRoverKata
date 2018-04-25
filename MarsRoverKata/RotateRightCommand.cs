using System;

namespace MarsRoverKata
{
    class RotateRightCommand : ICommand
    {
        public bool CanExecute(char command)
        {
            return command == 'R';
        }

        public RoverPosition Execute(RoverPosition roverPosition)
        {
            switch (roverPosition.Direction)
            {
                case 'N':
                    return new RoverPosition(roverPosition.X, roverPosition.Y, 'E');
                case 'E':
                    return new RoverPosition(roverPosition.X, roverPosition.Y, 'S');
                case 'S':
                    return new RoverPosition(roverPosition.X, roverPosition.Y, 'W');
                case 'W':
                    return new RoverPosition(roverPosition.X, roverPosition.Y, 'N');
                default:
                    return roverPosition;
            }
        }
    }
}
