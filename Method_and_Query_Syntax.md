# C# - Method and Query Syntax in LINQ

## Query Syntax

There are three parts in a basic LINQ query:

- `from` (\*required) - declares a variable to iterate through the sequence
- `where` (optional) - picks elements from the sequence if they satisify the given condition
- `select` (\*required) - determinates what is returned for each element in the sequence

```c#
string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

var shortHeroes = from h in heroes
  where h.Length < 8
  select h;
```

Example: Optional `where` and use `select` to create a new string starting with "HERO: "

```c#
var heroTitles = from hero in heroes
  select $"HERO: {hero.ToUpper()};
```

Output would look like `"HERO: D. VA"`, `"HERO: LUCIO"`, etc.

## Method Syntax

Query operator is written as a regular method call in method syntax.

### Where

`where` operator written as `Where()` method which takes a lambda expression as an argument

_Recall lambda expressions are a quick way to write a method_

If lambda expression returns `true`, element is added to the resulting collection

```c#
string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
var shortHeroes = heroes.Where(h => h.Length < 8);
```

### Select

Use `select` operator (`Select()` in method syntax) to transform each element in a sequence.

`Select()` also takes a lambda expression.

```c#
string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
var loudHeroes = heroes.Select(h => h.ToUpper());
```

### Combining `Where()` and `Select()`

Two ways to combine the two operators:

1. Separate statements (and separate variables...)

```c#
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
```

2. Chain the expressions

```c#
var longLoudHeroes = heroes
.Where(h => h.Length > 6)
.Select(h => h.ToUpper());
```

## When to Use Which Syntax?

```c#
// Query syntax
var longLoudheroes = from h in heroes
  where h.Length > 6
  select h.ToUpper();

// Method syntax - separate statements
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());

// Method syntax - chained expressions
var longLoudHeroes2 = heroes
  .Where(h => h.Length > 6)
  .Select(h => h.ToUpper());
```

> General practice:
>
> 1. For single operator queries, use **method syntax**
> 2. For everything else, use **query syntax**
