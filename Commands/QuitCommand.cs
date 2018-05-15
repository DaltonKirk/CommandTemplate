using System;

namespace CommandTemplate.Commands
{
    public class QuitCommand : ICommand
    {
        public void Action()
        {
            Environment.Exit(0);
        }
    }
}