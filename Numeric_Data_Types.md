# C# - Numeric Data Types

## Int

- `int` for whole integer value

```c#
int variableName = 7;
```

## Decimal Value

- Can use `float`, `double`, and `decimal` to show number with decimal value

- More often than not will be using `double` -- more precise than `float`, and faster to process than `decimal`

- Use `decimal` for financial applications b/c most accurate

```c#
double variableName = 39.76876;
```

- Must add `m` character after number when declaring `decimal`

```c#
decimal variableName = 489872.76m;
```

## Arithmetic Operators

- Math operations with two different numeric data types will return the more precise one

```c#
Console.WriteLine(5 / 3); // Output is int: 1
Console.WriteLine(5 / 3.0); // Output is double: 1.66667
```

## Built-in Math Methods

- `Math.Abs()` - find absolute value of a number

- `Math.Pow()` - returns a `double` value of a number (`@param1`) raised to the specified power (`@param2`)

- `Math.Sqrt()` - find square root of a number

- `Math.Ceiling()` - round **up** given `double` or `decimal` to nearest whole number

- `Math.Floor()` - round **down** given `double` or `decimal` to nearest whole number

- `Math.Min()` - returns the smaller of two numbers

- `Math.Max()` - returns the larger of two numbers
