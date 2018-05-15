using System;

namespace CommandTemplate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var session = new Session();
            
            while (session.isRunning)
            {
                session.Update();       
            }
        }
    }
}