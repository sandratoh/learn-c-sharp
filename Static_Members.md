# C# - Introduction to Static Members

- `static` members - facts and behaviours that are **associated with the class itself** (instead of instances of that data type)

## Static Fields and Properties

- To make a static field and property, just add `static` keyword after access modifier (`public` or `private`)

```c#
class Forest
{
  private static string definition;
  public static string Definition
  {
    get { return definition; }
    set { definition = value; }
  }
}
```

- Must access static members from class, and NOT from instances (will receive error if accessed with an instance reference)

```c#
static void Main(string[] args)
{
  Console.WriteLine(Forest.Definition);
}
```

## Static Methods

- Define behaviours that apply to the class itself

- Add `static` keyword after access modifier (`public` or `private`) to **both** the field and the method

  - Why? Because static members can only access other static members (can NOT access instance members)

```c#
class Forest
{
  private static string definition; // Must add `static` here or will have error
  public static void Define()
  {
    Console.WriteLine(definition);
  }
}
```
