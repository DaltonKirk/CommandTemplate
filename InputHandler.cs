using System;
using System.Collections.Generic;
using CommandTemplate.Commands;

namespace CommandTemplate
{
    public class InputHandler
    {
        public readonly Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>()
        {
            {"quit", new QuitCommand()},
            {"help", new HelpCommand()},
        };

        public void HandleInput(string input)
        {
            input = input.ToLower();

            ICommand activeCommand = null;
            _commands.TryGetValue(input, out activeCommand);
            if (activeCommand != null)
            {
                activeCommand?.Action();
            }
            else
            {
                Console.WriteLine(input + " is not recognised");
            }
        }

    }
}