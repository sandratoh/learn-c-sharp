# C# - Intro to Lists

A list is a sequential data structure that can hold any type.

## Array vs List

### Array drawbacks:

- Limited length
- Keeping track of number of elements using separate index
- Can only edit one element at a time

_Lists resolve all of these issues!_

### Lists:

- Generic and sequential collection of values
- Can hold references to any type
- Have (effectively) unlimited length
- Automatically track # of actual elements in the list
- Have handy methods to work with multiple elements at a time (e.g. `Add`, `Remove`, `AddRange`)

> Lists actually use arrays! C# compiler constructs an array and store elements there when we create a list.

Use array when we have a pre-determined number of elements.

Use lists when number is unknown, or you'd like the extra features.

## Creating and Adding

- Specify type of element inside angel brackets `< >`

```c#
List<string> citiesList = new List<string>();
```

- Add elements to list using `Add()` method

```c#
citiesList.Add("Vancouver");
```

- Access elements using indices and square brackets

```c#
string city = citiesList[0];
```

- Re-assign elements using bracket notation

```c#
citiesList[0] = "Toronto";
```

- To use list, must add this to the top of the file (formal class name = generic `List<T>` class)

```c#
using System.Collections.Generic;
```

### Object Initialization

Use one line to create and add list items.

Note syntax differences:

- **Basic construction:**

  - uses parantheses `( )`, and
  - no values

  ```c#
  List<string> citiesList = new List<string>();
  citiesList.Add("Calgary");
  citiesList.Add("Montreal");
  ```

- **Object initialization:**

  - uses curly braces`{ }`, and
  - the actual values go in-between

  ```c#
  List<string> citiesList2 = new List<string> { "Calgary", "Montreal" };
  ```

## Count and Contains

Two methods to check status og list:

1. Using the `Count` property

```c#
List<string> citiesList = new List<string> { "Delhi", "Los Angeles" };
int numberCities = citiesList.Count;
// numberCities is 2
```

2. Check if an element exists using `Contains()` method

```c#
bool hasDelhi = citiesList.Contains("Delhi");
bool hasDubai = citiesList.Contains("Dubai");
// hasDelhi is true, hasDubai is false
```

## Removing and Clearing from List

Use `Remove()` method to remove specific item from a list

```c#
List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Kiev" };
bool success = citiesList.Remove("Delhi");
// success is true
```

If item does NOT exist in list, the method call returns `false`

```c#
success = citiesList.Remove("Dubai");
```

Use `Clear()` method to clear entire list

```c#
List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Kiev" };
citiesList.Clear();

Console.WriteLine(citiesList.Count);
// Output: 0
```

## Working with Ranges

Use if we want to add, access, or remove multiple elements at once:

- `AddRange()` - add values to the end of the list

- `InsertRange()` - add values at `int` index

- `RemoveRange()` - remove values at `int` index for `int` number of elements

- `GetRange()` - returns a list at desired index for desired range of elements

## Looping through List

Two methods:

1. `for` loops with `Count`

```c#
for (int i  = 0; i < numbers.Count; i++)
{
   Console.WriteLine(number);
}
```

2. `foreach` loop

```c#
foreach (int number in numbers)
{
  Console.WriteLine(number);
}
```
