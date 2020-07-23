using System;

namespace MyFirstLibrary
{
    public class HelloWorld
    {
        /// <summary>
        /// Additional message to the world
        /// </summary>
        public string Message { get; set; }
        
        /// <summary>
        /// Default Construktor
        /// </summary>
        public HelloWorld()
        {
        }
        /// <summary>
        /// Write "Hello World :)" and additional Message to console
        /// </summary>
        private void SayHelloWorld()
        {
            Console.WriteLine("Hello World :)");
            if (Message.Length > 0)
            {
                Console.WriteLine(Message);
            }
        }
    }
}
