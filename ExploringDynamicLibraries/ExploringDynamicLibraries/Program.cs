using System;
using System.Collections.Generic;
using System.Reflection;

namespace ExploringDynamicLibraries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Loading dynamic library...");
            List<Type> LibraryTypes = new List<Type>();
            LibraryTypes.AddRange(Assembly.Load("MyFirstLibrary").GetTypes());
            foreach (var type in LibraryTypes)
            {
                Console.WriteLine(type.AssemblyQualifiedName);
            }
            Console.WriteLine("Done");
        }
    }
}
