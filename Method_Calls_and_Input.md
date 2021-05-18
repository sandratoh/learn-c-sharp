# C# - Method Calls and Inputs

## Define a Method

- Basic structure of a method definition:

```c#
static void YourMethodName(string identity, int age)
{
  Console.WriteLine($"{identity} is {age} years old.");
}

// Call method with parentheses
YourMethodName();
```

- C# naming convention: use `PascalCase` to name methods

## Named Arguments

- When calling methods, named arguments (colon syntax `:`) allow us to list arguments in any order

- We can mix named arguments with positional arguments
  - _Note: positional arguments MUST come before named arguments_

Example: Method with five optional parameters

```c#
static void YourMethodName(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0) {...}

// By default, methods get called with positional arguments
YourMethodName(4); // set a = 4

// Calling method with named arguments
YourMethodName(d: 4); // set d = 4
YourMethodName(d: 4, b: 1, a: 2); // can list in any order

// Mixing named arguments with positional arguments
YourMethodName(2, 1, d: 4) // Okay: a is 2, b is 1, d is 4
YourMethodName(d: 4, 2, 1) // Error!
```

## Method Overloading

- Multiple versions of built-in method with the same name: each "version" = an _overload_

- Overloads differ by either:

  1. paramter types, or
  2. number of parameters

- In C#, when methods are "different", we're referring to their method _signatures_ (**method's name** and **parameter types in order**)

- Example: `Math.Round(Double, Int32)` and `Math.Round(Double)`

Overload 1: `Math.Round(Double, Int32)` - rounds the `double` to the `int`'s # of decimal points

```c#
Math.Round(3.14159, 2); // returns 3.14
```

Overload 2: `Math.Round(Double)` - rounds the `double` to the nearest integer

```c#
Math.Round(3.14159); // returns 3
```
