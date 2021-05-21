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
