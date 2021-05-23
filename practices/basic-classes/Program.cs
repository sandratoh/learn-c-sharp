using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Amazon", "Tropical");
      //   f.Trees = 1123;
      //   f.Age = 200; // Error: set accessor is inaccessible

      Console.WriteLine(f.Name);

      Forest f2 = new Forest("Congo");

      Console.WriteLine(f2.Biome);

      Console.WriteLine(f.Trees);

      f.Grow();

      Console.WriteLine(f.Trees);

      Forest.PrintTreeFacts();
    }
  }
}
