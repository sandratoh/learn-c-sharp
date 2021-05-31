# C# - String the Exception

- `String` and `string` are equivalent in C#

- Strings are technically reference types but with some unique behaviours

## Value Type Behaviour

- A `string` reference will always point to the original object, so modifying one reference will not affect other references

  - strings are _immutable_, anything that appears to modify a string actually returns a new `string` object

  ```c#
  // Example 1
  string dog = "chihuahua";
  string tinyDog = dog;
  dog = "dalmation";
  Console.WriteLine(dog);
  // Output: "dalmation"
  Console.WriteLine(tinyDog);
  // Output: "chihuahua"

  // Example 2
  string s1 = "Hello ";
  string s2 = s1;
  s1 += "World";
  System.Console.WriteLine(s1);
  // Output: "Hello World"
  System.Console.WriteLine(s2);
  // Output: "Hello"
  ```

- Comparing strings with equality operator (`==`) performs a **value comparison** (NOT referential)

  ```c#
  string s = "hello";
  string t = "hello";
  // b is true
  bool b = (s == t);
  ```

## Null, Empty, or Unassigned Strings

Like `object` and other reference types, `string` references can be `null` or `unassigned`. String also has a special third value: **empty**.

- **Unassigned**: programmer did not give the variable any value

- **Null**: programmer intentionally made the variable refer to no object

- **Empty**: signifies a piece of text with zero character. Often to represent a blank text field
  - Can use `""` or `String.Empty`

```c#
// Unassigned
string s;
// Null
string s2 = null;
// Empty string
string s3 = "";
// Also empty string
string s4 = String.Empty;
// This prints true
Console.WriteLine(s3 == s4);
```

- Use `String.Empty` or `""` instead of `null` to avoid `NullReferenceException` errors.

- Check for null OR empty string using method `String.IsNullOrEmpty()`

```c#
using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
     Console.Write("Your favourite color: ");
     string color = Console.ReadLine();

     if (String.IsNullOrEmpty(color))
     {
       Console.WriteLine("You didn't enter anything!");
     }
     else
     {
       Console.WriteLine("Thank you for your submission!");
     }
    }
  }
}
```
