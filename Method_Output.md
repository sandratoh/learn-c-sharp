# C# - Method Output

## Out

- A method can only _return_ one value, but sometimes we need to output two pieces of info: use `out` parameter

- Example: `Int32.TryParse()` method tries to parse string input as integer and will return a boolean (parse success?) and set variable as new value (variable set to `null` if unable to parse)

Method Signature of `Int32.TryParse()`:

```c#
public static bool TryParse (string s, out int result);
```

`Int32,TryParse()` and `out` param in action:

```c#
int number;
bool success = Int32.TryParse("10602", out number);
// number is 10602 and success is true
int number2;
bool success2 = Int32.TryParse(" !!! ", out number2);
// number2 is 0 and success2 is false
```

One-liner Shortcut:

```c#
bool success = Int32.TryParse("10602", out int number);
// Declare `int` variable from within the method call
```

## Using Out

- Can use `out` parameters in our own methods

> **Requirements**
>
> - `out` parameter must have the `out` keyword and its expected type
> - `out` parameter must be set to a value before the method ends

_Note: Remember to call method with `out` keyword as well!_

Example: `Yell()` converts `phrase` to uppercase, and setting boolean variable to `true`

```c#
// Method declaraion
static string Yell(string phrase, out bool wasYellCalled)
{
  wasYellCalled = true;
  return phrase.ToUpper();
}


string message = "garrrr";
Yell(message, out bool flag);
// returns "GARRRR" and flag is true
```
