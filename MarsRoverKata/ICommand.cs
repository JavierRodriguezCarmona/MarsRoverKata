namespace MarsRoverKata
{
    public interface ICommand
    {
        bool CanExecute(char command);
        RoverPosition Execute(RoverPosition roverPosition);
    }
}
