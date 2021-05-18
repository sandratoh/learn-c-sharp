# C# - Alternate Expressions

- Shortcuts for defining methods and making them more readable:
  - Expression-bodied definitions
  - Lambda expressions

## Expression-bodied Definitions

- Great for writing one-line methods -- one _expression_

- Refactor code to an expression-bodied definition by:
  - removing curly braces and `return` keyword
  - adding "fat arrow/squid" (`=>`) from _method signature_ to _method body_

```c#
// Regular method declaration
bool isEven(int num)
{
  return num % 2 == 0;
}

// Expression-bodied definition
bool isEven(int num) => num % 2 == 0;
```

## Methods as Arguments

- There are methods that will accept other methods as arguments

- Think of it like having a callback function as argument

- Argument method gets called by the outer method

  - Don't need to call it or add `()` in argument, just write method name

- Example: `Array.Exists()` - determines whether an array contains elements that match a condition

```c#
// Declare array and method
int[] numbers = {1, 3, 5, 6, 7, 8};

public static bool IsEven(int num)
{
  return num % 2 == 0
};

// `IsEven` method is called with each value in array to check for even #
bool hasEvenNumber = Array.Exists(numbers, IsEven);
```

## Lambda Expressions

- Great for when we need to pass a method as an argument

- Similar to an expression-bodied definition, but can be multi-line as well (2+ lines: add curly braces (`{}`) and semicolon (`;`))

- Inner argument method is an _anonymous method_

One-Line Example: Refactored `hasEvenNumber` method frm previous example

```c#
bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0 );
```

Multi-Line Example: Check if array element is a multiple of 12 and greater than 20

```c#
bool hasBigDozen = Array.Exists(numbers, (int num) => {
  bool isDozenMultiple = num % 12 == 0;
  bool greaterThan20 = num > 20;
  return isDozenMultiple && greaterThan20;
});
```

### Shorter Lambda Expressions

1. Can remove parameter type if it can be inferred

2. Can remove parantheses, if there is only one parameter

```c#
// Regular lambda
bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0 );

// Shorter lambda
bool hasEvenNumbers = Array.Exists(numbers, num => num % 2 == 0 );
```
