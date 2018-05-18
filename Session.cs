using System;

namespace CommandTemplate
{
    public class Session
    {
        public bool isRunning { get; set; }

        public Session()
        {
            isRunning = true;
        }

        public void Update()
        {
            InputHandler.HandleInput(Console.ReadLine());
        }
    }
}