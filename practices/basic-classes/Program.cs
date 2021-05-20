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
      f.age = 200;
      f.Biome = "Tropical";

      Console.WriteLine(f.Name);
    }
  }
}
