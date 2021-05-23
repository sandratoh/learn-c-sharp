# C# - Main()

- The entry point for any program: `Main()` method

- Each time we run `dotnet run`, the `Main()` method is called

```c#
class Program
{
  public static void Main (string[] args)
  {
  }
}
```

## Breaking Down the Method

- `Main()` is a method of the Program class.
- `public` — The method can be called outside the `Program` class.
- `static` — The method is called from the class name: `Program.Main()`.
- `void` — The method means returns nothing.
- `string[] args` — The method has one parameter named `args`, which is an array of strings.

## Example

```c#
using System;

namespace ApplyingClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        string mainPhrase = String.Join(" and ", args);
        Console.WriteLine($"My favorite fruits are {mainPhrase}!");
      }
    }
  }
}
```

```bash
$ dotnet run mango pineapple lychee # command
My favorite fruits are mango and pineapple and lychee! # output
```
