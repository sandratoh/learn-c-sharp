# C# - Converting Data Types

- Variables in C# are strictly typed

- **Data type conversion** = strategy used when you want to change the data type of a stored variable

- When converting data, C# will make sure no data is lost

## Implicit Conversion

- Happens automatically if no data will be lost during conversion

- Example: Converting `int` to `double` works but NOT the other way around (b/c `double` can hold more data)

```c#
int myInt = 3;
// Turn it into a decimal
double myDouble = myInt;
```

## Explicit Conversion I: Cast Operator

- Require a _cast operator_ to convert data type

- Example: Converting `double` to `int`, need to use operator `(int)`

```c#
double myDouble = 3.2;

// Round myDouble to the nearest whole number
int myInt = (int)myDouble;
```

## Explicit Conversion II: Built-In Methods

- Use built-in `Convert` class methods to convert data types

- Example: `Convert.ToString()`, `Convert.ToDouble()`

## Usage

- Example: `Console.ReadLine()` will always return a `string`, must convert explicitly if you want to store user input as an `int`

```c#
using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int
      int faveNumber = Convert.ToInt32(Console.ReadLine());

      // Check converted data type
      Console.WriteLine($"Data type of faveNumber is {faveNumber.GetType()}");
      // Output: Data type of faveNumber is System.Int32

      Console.WriteLine(faveNumber.GetType() == typeof(int));
      // Output: True
    }
  }
}

```

- Example: Converting a `string` to an array of `char`

```c#
using System;

namespace CharList
{
  class Program
  {
    static void Main(string[] args)
    {
      string word = "Hello world";

      char[] charList = word.ToCharArray();

      Console.WriteLine(charList); // Output: Hello world

      Console.WriteLine(charList.GetType()); // Output: System.Char[]

      foreach (char letter in charList)
      {
        Console.WriteLine(letter);
      }
    }
  }
}
```

- Example: Converting a character from `string` to `char`

```c#

string myString = "h";

char implicitError = myString; // Error
char implicitSuccess = myString[0]; // Okay

char explicitError = (char)myString; // Error
char explicitSuccess = Convert.ToChar(myString); // Okay

```
