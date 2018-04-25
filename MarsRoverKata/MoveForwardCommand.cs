using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    class MoveForwardCommand : ICommand
    {
        public bool CanExecute(char command)
        {
            return command == 'F';
        }

        public RoverPosition Execute(RoverPosition roverPosition)
        {
            switch (roverPosition.Direction)
            {
                case 'N':
                    return new RoverPosition(roverPosition.X, roverPosition.Y + 1, roverPosition.Direction);
                case 'E':
                    return new RoverPosition(roverPosition.X + 1, roverPosition.Y, roverPosition.Direction);
                case 'S':
                    return new RoverPosition(roverPosition.X, roverPosition.Y - 1, roverPosition.Direction);
                case 'W':
                    return new RoverPosition(roverPosition.X - 1, roverPosition.Y, roverPosition.Direction);
                default:
                    return roverPosition;
            }
        }
    }
}
