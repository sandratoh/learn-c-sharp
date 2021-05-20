using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Amazon", "Tropical");
      f.Trees = 1123;
      //   f.Age = 200; // Error: set accessor is inaccessible

      Console.WriteLine(f.Name);
    }
  }
}
