// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// imports classes, such as `Console` that are defined in the `System` namespace
// using System;

// // a `namespace` is a container (or scope) for classes
// namespace CSharp.Intro
// {
//     // this is a class - don't worry about the `internal` bit for now
//     internal class Program
//     {
//         // static methods are like Ruby's class methods
//         // void means that this method returns nothing
//         // the main method takes an array of strings as an arg - `string[]`
//         static void Main(string[] args)
//         {
//             // The main method is called automatically when you execute the program
//             // When that happens, you'll see "Hello, Makers!" printed to the terminal
//             Console.WriteLine("Hello Makers!");
//         }
//     }
// }


// using System;

// namespace CSharp.Intro
// {
//   class Calculator
//   {
//     static void Main(string[] args)
// {
//     new Calculator().Calculate();
// }
//     // what does this method return?
//     public void Calculate()
//     {
//       // note that the we have to declare a type (int) for the variable (result)
//       int result = 2 + 2;
//       Console.WriteLine("The result is {0:d}", result);
//     }
//   }
// }



using System;

namespace CSharp.Intro
{
  class Clock
  {
    static void Main(string[] args)
{
    new Clock().DisplayTime();
}
    public void DisplayTime()
    {
      DateTime date1 = DateTime.Now;
      Console.Write("The current ");
      Console.ForegroundColor = ConsoleColor.Red; // sets the color of the text in the console to red
      Console.Write("time ");
      Console.ResetColor();
      Console.WriteLine(date1.ToString ("H:mm"));
    }

// function is public, returns a string, expects a string argument
    // public String DisplayHello(String name){
    //   return "Hello World, " + name;
    // }

  }
}

