using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTemplate.Commands
{
    class HelpCommand : ICommand
    {
        public void Action()
        {
            Console.WriteLine("Available Commands:");
            foreach (var command in new InputHandler()._commands)
            {
                Console.WriteLine(command.Key);
            }
        }
    }
}
