using CommandTemplate.Commands;
using System;
using System.Collections.Generic;

namespace CommandTemplate
{
    public static class InputHandler
    {
        public static List<ICommand> history = new List<ICommand>();

        public static Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>()
        {
            {"quit", new QuitCommand()},
            {"help", new HelpCommand()},
            {"clear", new ClearCommand()},
            {"undo", new UndoCommand()},
            {"change command", new ChangeCommand()},
        };

        public static void HandleInput(string input)
        {
            input = input.ToLower();

            ICommand activeCommand = null;
            _commands.TryGetValue(input, out activeCommand);
            if (activeCommand != null)
            {
                activeCommand?.Action();
                history.Add(activeCommand);
            }
            else
            {
                Console.WriteLine(input + " is not recognised");
            }
        }
    }
}