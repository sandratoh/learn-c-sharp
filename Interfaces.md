# C# - Intro to Interfaces

- **Interfaces** - sets of actions and values that describe how a class can be used

  - include properties, methods, and other members

  - declared with signature, but doesn't define behaviours

- A class _implements_ an interface if it defines those properties, methods, and other members

- Naming convention: start with `I` for `interface` to differentiate from a `class`

```c#
interface IAutomobile
{
  string LicensePlate { get; }
  void Vroom();
  // Note how property and method bodies are not defined
}
```

## Implementing an Interface

- Implement interface into class using colon syntax `:`

- Define members in interface through our class

- A class can implement multiple interfaces

```c#
class Sedan : IAutomobile
{
  public string LicensePlate { get; }
  public void Vroom()
  {
    Console.WriteLine("Zoom zoom...");
  }
}
```

## Constraints of Interfaces

- Cannot specify two types of members:

  1. Constructors
  2. Fields

- Remove duplicated code in classes with _inheritance_
