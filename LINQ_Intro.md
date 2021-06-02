# C# - Intro to LINQ

## What is LINQ?

Like an add-on to C# and .NET that allows programmers to use new syntax and methods with data.

- Works for complex selections and transformations

- Works on local and remote data sources

- Each selection/transformation is called a _query_

- Can be used with any type that supports `foreach` loops (eg: arrays, lists)

Example: Querying from data

```c#
string[] names = { "Tiana", "Dwayne", "Helena" };
var filteredNames = from n in names
  where n.Contains("a")
  select n;
```

Example: Using `Where()` method

```c#
var shortNames = names.Where(n => n.Length < 4);
```

## Importing LINQ

Must first import features into code before using LINQ. Add line below to top of file:

```c#
using System.Linq;
```

Often use LINQ with generic collections (like lists):

```c#
using System.Collections.Generics;
using System.Linq;
```

## Var

- Every LINQ query returns either:

  1. a single value, or
  2. an object of type `IEnumerable<T>` - works with `foreach` loops and can check length with `Count()`

- Since singlue value type and/or parameter type `T` is not always known, it is common to store query returned value in variable type `var`

- `var` = implicitly typed variable letting C# compiler determine actual type for us

```c#
List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

// Query syntax
var shortHeroes = from h in heroes
  where h.Length < 8
  select h;

foreach (var hero in shortHeroes)
{
  Console.WriteLine(hero);
}

// Method syntax
var longHeroes = heroes.Where(n => n.Length > 8);

Console.WriteLine(longHeroes.Count());
```

## Method and Query Syntax

There are two ways to write queries in LINQ:

1. Query Syntax
2. Method Syntax

### Query Syntax

- Looks like a multi-line sentence
- Similar to SQL

```c#
var shortHeroes = from h in heroes
  where h.Length < 8
  select h;
```

### Method syntax

- Looks like C# code
- Make method calls on collection we are querying

```c#
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
```

In LINQ, we will see `where`/`Where()` and `select`/`Select()` show up as both keywords and method calls. These are generally called **operators**.
