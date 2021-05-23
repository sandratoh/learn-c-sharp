# C# - Intro to Interfaces

- **Interfaces** - sets of actions and values that describe how a class can be used

  - include properties, methods, and other members

  - declared with signature, but doesn't define behaviours

- A class _implements_ an interface if it defines those properties, methods, and other members

- Naming convention: start with `I` for `interface` to differentiate from a `class`

```c#
interface IAutomobile
{
  string Id { get; }
  void Vroom();
  // Note how property and method bodies are not defined
}
```
