using System.Collections.Generic;

namespace MarsRoverKata
{
    public static class CommandParser
    {
        public static List<ICommand> Parse(string stringCommands)
        {
            var commands = new List<ICommand>();
            var splitStringCommands = stringCommands.ToCharArray();
            foreach (var splitStringCommand in splitStringCommands)
            {
                switch (splitStringCommand)
                {
                    case 'R':
                        commands.Add(new RotateRightCommand());
                        break;
                    case 'L':
                        commands.Add(new RotateLeftCommand());
                        break;
                    case 'F':
                        commands.Add(new MoveForwardCommand());
                        break;
                    case 'B':
                        commands.Add(new MoveBackwardsCommand());
                        break;
                }
            }

            return commands;
        }
    }
}