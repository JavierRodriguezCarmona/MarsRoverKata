using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace MarsRoverKata
{
    public class MarsRover
    {
        public RoverPosition CurrentPosition { get; private set; }
        private List<ICommand> commands = new List<ICommand>
        {
            new RotateRightCommand(),
            new RotateLeftCommand(),
            new MoveForwardCommand(),
            new MoveBackwardsCommand()
        };

        public MarsRover(RoverPosition currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public void ProcessCommands(string stringCommands)
        {
            foreach (var stringCommand in stringCommands)
            {
                CurrentPosition = commands.First(c => c.CanExecute(stringCommand)).Execute(CurrentPosition);
            }
        }
    }
}