namespace MarsRoverKata
{
    class RotateLeftCommand : ICommand
    {
        public bool CanExecute(char command)
        {
            return command == 'L';
        }

        public RoverPosition Execute(RoverPosition roverPosition)
        {
            switch (roverPosition.Direction)
            {
                case 'N':
                    return new RoverPosition(roverPosition.X, roverPosition.Y, 'W');
                case 'E':
                    return new RoverPosition(roverPosition.X, roverPosition.Y, 'N');
                case 'S':
                    return new RoverPosition(roverPosition.X, roverPosition.Y, 'E');
                case 'W':
                    return new RoverPosition(roverPosition.X, roverPosition.Y, 'S');
                default:
                    return roverPosition;
            }
        }
    }
}
