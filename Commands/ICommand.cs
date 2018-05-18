namespace CommandTemplate.Commands
{
    public interface ICommand
    {
        void Action();

        void Undo();

        string Description();
    }
}