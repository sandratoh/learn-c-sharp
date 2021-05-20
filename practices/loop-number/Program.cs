using System;

namespace EvenOrOddLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = { 1, 3, 4, 6, 7, 9, 11, 12 };

      foreach (int number in numbers)
      {
        // Must assign to variable -- not all expressions can be statements in C#
        string result = number % 2 == 0 ? "EVEN" : "ODD";

        Console.WriteLine(result);
      }
    }
  }
}
