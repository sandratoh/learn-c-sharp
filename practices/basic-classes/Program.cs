using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Amazon";
      f.trees = 1123;
      f.age = 200;
      f.biome = "tropical rainforest";

      Console.WriteLine(f.name);
    }
  }
}
