// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace CSharp.Intro
{
  class Calculator
  {
    static void Main(string[] args)
{
    new Calculator().Calculate();
}
    // what does this method return?
    public void Calculate()
    {
      // note that the we have to declare a type (int) for the variable (result)
      // int result = 2 + 2;
     double result= 2.5 + 2.5;
      Console.WriteLine("The result is {0}", result);
    }
  }
}
