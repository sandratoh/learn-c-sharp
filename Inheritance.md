# C# - Inheritance

- With **inheritance**, you can define one _superclass_ that contains the shared members for other classes to _inherit_

## Superclass and Subclass

- _Subclass/derived class_ inherits from _superclass/base class_

- A class can only inherit from one base class

## Syntax

- A subclass inherits/extends a superclass using colon syntax `:`

### Implementing Inheritance with Interface

- Separate inheritance and interface with commas `,`

- Ensure superclass comes before any interfaces

```c#
class Sedan : Vehicle, IAutomobile
{
}
```

## Protected Access Modifier

- Use `protected` access modifier to allow current class and subclasses access

- Why use `protected`?

  - `public` is unsecure

  - `private` is too restrictive - only allows current class access

## Access Inherited Members with Base

- Refer to a superclass inside a subclass with `base` keyword

```c#
class Sedan : Vehicle
{
  // `Sedan` constructor inherits from `Vehicle` constructor
  public Sedan (double speed) : base(speed)
  {
  }
}
```

- Subclass constructor will implicitly call the default parameterless superclass constructor if it doesn't explicitly use `base()`

```c#
class Sedan : Vehicle
{
  // Implicitly calls base(), aka Vehicle()
  public Sedan (double speed)
  {
  }
}
```

- Code below is the same as above, but the code below will only work if there's a `Vehicle()` constructor created

```c#
class Sedan : Vehicle
{
  public Sedan (double speed) : base()
  {
  }
}
```
