﻿using System;

namespace CommandTemplate.Commands
{
    public class QuitCommand : ICommand
    {
        public void Action()
        {
            Environment.Exit(0);
        }

        public string Description()
        {
            return "Quits the application";
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}