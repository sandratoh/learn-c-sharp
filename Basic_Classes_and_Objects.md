# C# - Basic Classes and Objects

## Fields

- One type of class _member_ - general term for building blocks of a class

- Different pieces of data in a class

- Similar to defining a variable

```c#
class Forest
{
  public string name;
  public int tress
}
```

## Properties

- Each property controls access (getting and setting) for a field

- Another type of class member

- A property is made up of **two** methods:

  - `get()` method (getter) - called when proeprty is accessed

  - `set()` method (setter) - called when property is assigned a value

- Common practice: name a property with the title-cased version of its field's name

  - Eg: `age` (field) vs `Age` (property)
  - Eg: `name` (field) vs `Name` (property)

```c#
// Field
public string name;

// Property
public string Name
{
  // Getter and Setter without validations
  get { return name; }
  set { name = value; }
  // `value` = keyword for what we assign when using property
}

```

```c#
public int area;

public int Area
{
  get { return area; }
  // Setter with validation
  set
  {
    if (value < 0) { area = 0; }
    else { area = value; }

  }
}
```

### Using Property

```c#
Forest f = new Forest();
f.Area = -1; // set() is called, value = -1
Console.WriteLine(f.Area); // get() is called; prints 0
```

### Automatic Properties

- Short-hand for basic getter and setter pattern

- Don't have to write:

  - `get()` method
  - `set()` method
  - field -- hidden field is defined in background!

- Just need to worry about property

**Basic pattern:**

```c#
public string size;
public string Size
{
  get { return size; }
  set { size = value; }
}
```

**Automatic property:**

```c#
public string Size
{ get; set; }
```

## Public vs. Private Access

- `public` - a public member can be accessed by any class

  - Eg: Allows `Main()` method to access code from the `Forest` class

- `private` - a private member can only be accessed by code in the same class

- **Encapsulation** ~ defensive coding: need to use `public` and `private` together to encapsulate our classes

- Good practice:

  - `private` fields
  - `public` properties

- C# defaults:

  - `private` class members
  - `public` classes

## Get-Only Properties

- Two options available if we only want program to **get** value of property, and **NOT set** value:

  1. don't include a `set()` method, or

  2. make the `set()` method private (_preferred: allow other class methods to access_)

**Approach 1** - don't include a `set()`

```c#
public string Area
{
  get { return area; }
}
```

Will get error if you try setting _anywhere_

```bash
error CS0200: Property or indexer 'Forest.Area' cannot be assigned to (it is read-only)
```

**Approach 2** - make `set()` private

```c#
public int Area
{
  get { return area; }
  private set { area = value; }
}
```

Will get error only if you try to set _outside_ of `Forest` class

```bash
error CS0272: The property or indexer 'Forest.Area' cannot be used in this context because the set accessor is inaccessible
```

## Methods

- Third type of member in classes

- Used to define how an instance of a class behaves

- The _actions_ that an object can perform (its _behaviour_)

### Constructors

- Special type of method that gets called whenever an object is instantiated with `new`

- Syntax:

  - No return type listed
  - Method name = name of its enclosing class

- **Parameterless constructor**: if no constructor is defined in class, C# will automatically create one that takes no parameter

```c#
class Forest
{
  public Forest(int area)
  {
    Area = area;
    // Add more constructor values here
  }
}
```

```c#
// Constructor is called
Forest f = new Forest(400);
```

```c#
// Parameterless constructor auto-created
Forest f = new Forest();
```

## this

- Use `this` keyword to refer to current instance of class

- For specifying the instance properties

```c#
class Forest
{
  public int Area
  { /* property omitted */ }

  public Forest(int area)
  {
    this.Area = area;
  }
}
```

## Overloading Constructors

- Like method overloads, we can define additional constructors that take different # of arguments

- Two ways to remove duplicated code:

  1. Use default arguments - will be the only difference between constructors (for C# 4.0+)

  ```c#
  public Forest(int area, string country = "Unknown")
  {
    this.Area = area;
    this.Country = country;
  }
  ```

  2. Use `: this()` to refer to another constructor in same class (for older C# before 4.0, or when second constructor has additional functionality)

  ```c#
  public Forest(int area, string country)
  {
    this.Area = area;
    this.Country = country;
  }

  // `this()` refer to first constructor above
  public Forest(int area) : this(area, "Unknown")
  {
    Console.WriteLine("Country property not specified. Value defaulted to 'Unknown'.");
  }
  ```
