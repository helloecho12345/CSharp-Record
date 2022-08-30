// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// imports classes, such as `Console` that are defined in the `System` namespace
using System;

// a `namespace` is a container (or scope) for classes
namespace CSharp.Intro
{
    // this is a class - don't worry about the `internal` bit for now
    internal class Program
    {
        // static methods are like Ruby's class methods
        // void means that this method returns nothing
        // the main method takes an array of strings as an arg - `string[]`
        static void Main(string[] args)
        {
            // The main method is called automatically when you execute the program
            // When that happens, you'll see "Hello, Makers!" printed to the terminal
            Console.WriteLine("Hello Makers!");
        }
    }
}
