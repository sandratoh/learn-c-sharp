using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Amazon";
      f.Trees = 1123;
      //   f.Age = 200; // Error: set accessor is inaccessible
      f.Biome = "Tropical";

      Console.WriteLine(f.Name);
    }
  }
}
