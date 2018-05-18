using System;

namespace CommandTemplate.Commands
{
    internal class ClearCommand : ICommand
    {
        public void Action()
        {
            Console.Clear();
        }

        public string Description()
        {
            return "Clears the console";
        }

        public void Undo()
        {
            Console.WriteLine("Can't undo 'clear'");
        }
    }
}