using System;

namespace CommandTemplate.Commands
{
    internal class HelpCommand : ICommand
    {
        public void Action()
        {
            Console.WriteLine("Available Commands:");
            foreach (var command in InputHandler._commands)
            {
                Console.WriteLine(command.Key);
            }
        }

        public string Description()
        {
            return "Shows list of all commands";
        }

        public void Undo()
        {
            Console.WriteLine("Can't undo help");
        }
    }
}