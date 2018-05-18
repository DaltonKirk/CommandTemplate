using System;

namespace CommandTemplate.Commands
{
    internal class ChangeCommand : ICommand
    {
        private string nameBefore;
        private ICommand command;
        private string nameAfter;

        public void Action()
        {
            var _commands = InputHandler._commands;
            Console.WriteLine("Enter command you wish to change");
            var strCommand = Console.ReadLine();
            _commands.TryGetValue(strCommand, out command);
            if (command != null)
            {
                Console.WriteLine("Command found. Enter new name...");
                var newName = Console.ReadLine();
                _commands.Remove(strCommand);
                if (_commands.ContainsKey(newName))
                {
                    Console.WriteLine("name taken by another command");
                }
                else
                {
                    nameBefore = strCommand;
                    nameAfter = newName;
                    _commands.Add(newName, command);
                    Console.WriteLine("Command {0}, renamed to {1}", nameBefore, nameAfter);
                }
            }
            else
            {
                Console.WriteLine(strCommand + " is not recognised");
            }
        }

        public string Description()
        {
            return "Changes the required input to execute a command";
        }

        public void Undo()
        {
            var _commands = InputHandler._commands;
            _commands.Remove(nameAfter);
            _commands.Add(nameBefore, command);

            Console.WriteLine("Command {0}, renamed to {1}", nameAfter, nameBefore);
        }
    }
}