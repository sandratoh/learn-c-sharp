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

## Override Inherited Members

- When we want modify inherited methods or values: use `override` and `virtual` modifers (can be added before or after `public`)

  - In super/base class, use `virtual` - overridable

    ```c#
    public virtual void SpeedUp()
    ```

  - In subclass, use `override`

    ```c#
    public override void SpeedUp()
    ```

- Alternative way - **method hiding** : [define a `new` member with same name](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords)

  - `override` _extends_ the base class `virtual` method, while `new` _hides_ an accessible base class method

  - `new` modifier can be added before or after `public`

  - Using `new` shows the program that you are aware the class member is modifying/hiding an inheritance from base class

### `override` or `new`?

- Typically wants to use `override` instead of `new`

- Possible error in method hiding: a base class reference variable pointing to a child class object will invoke the _hidden method in the Base class_

  - If you want it to invoke the child class method, use `override` instead

  ```c#
  BaseClass bcdc = new DerivedClass();

  // In method hiding, the method defined in DeriveClass is hidden, and base class method will be invoked
  ```

- Microsoft docs: You want objects that have values that are created from the derived class to use the methods that are defined in the derived class.

## Make Inherited members Abstract

- `abstract` members have no implementation in the superclass, but they must be implemented in all subclass

- When we want a method in all inherited class, but they must all be different from each other

- Add `abstract` line to base class:

  ```c#
  public abstract string Describe();
  ```

- Any class that contains an `abstract` method must be an `abstract` class as well - the class itself can't exist as an instance

  - Must also label the class with `abstract` keyword

  ```c#
  abstract class Vehicle
  ```

- To implement `abstract` method, need to label the method with `override` in subclasses
