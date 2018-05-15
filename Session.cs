using System;

namespace CommandTemplate
{
    public class Session
    {
        public bool isRunning { get; set; }
        private InputHandler input = new InputHandler();

        public Session()
        {
            isRunning = true;
        }

        public void Update()
        {
            input.HandleInput(Console.ReadLine());
        }
    }
}