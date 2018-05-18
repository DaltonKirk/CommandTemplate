using System;
using System.Linq;

namespace CommandTemplate.Commands
{
    internal class UndoCommand : ICommand
    {
        public void Action()
        {
            InputHandler.history.Last().Undo();
        }

        public string Description()
        {
            return "reverts last action if possible";
        }

        public void Undo()
        {
            Console.WriteLine("Can't Undo, Undo");
        }
    }
}