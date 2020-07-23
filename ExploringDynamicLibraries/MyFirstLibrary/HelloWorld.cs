using System;

namespace MyFirstLibrary
{
    public class HelloWorld : IMyFirstLibrary
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

        public void Abort()
        {
            Console.WriteLine($"Aborting {typeof(HelloWorld).FullName}... :(");
        }

        public void Dispose()
        {
            Console.WriteLine($"Disposing {typeof(HelloWorld).FullName}.");
        }

        public void Initialize()
        {
            Console.WriteLine($"Initialiszing {typeof(HelloWorld).FullName}. :)");
        }

        public void Run()
        {
            Console.WriteLine($"Running {typeof(HelloWorld).FullName}. :D");
            SayHelloWorld();
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
