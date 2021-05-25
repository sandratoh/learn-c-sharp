# C# - References

- Classes are _reference_ types - variable refers to a location in memory that has the object

- Every "primitive" data type is a value type - variable holds the actual data:

  - `int`
  - `double`
  - `bool`
  - `char`

- `string` is a little different

## References and Value Comparison

- When we compare reference types with `==`, the C# compiler performs a _referential_ comparison:

  - checks if two variable refers to the same memory location

```c#
Dissertation d1 = new Dissertation(50);
Dissertation d2 = new Dissertation(50);
Console.WriteLine(d1 == d2);
// Output: False -- pointing to different objects
```

```c#
Book b1 = new Book();
Book b2 = b1;
Console.WriteLine(b1 == b2);
// Output: True -- referring to same object
```

## Array of References

- We can use inherited classes **and** implemented interfaces to reference an object

  ```c#
  Dissertation diss = new Dissertation(50);
  IFlippable fdiss = diss;
  ```

- This allows us to work with similar types at the same time

- If we didn't have this feature and needed to 'flip' a group of `Dissertation` and `Diary` types:

  ```c#
  Diary dy1 = new Diary(1);
  Diary dy2 = new Diary(30);
  Dissertation diss1 = new Dissertation(50);
  Dissertation diss2 = new Dissertation(49);
  dy1.Flip();
  dy2.Flip();
  diss1.Flip();
  diss2.Flip();
  ```

  - Question: To store the references in an array and loop through, would it be an array of `Diary[]` or an array of `Dissertation[]` ?

- Being able to use implemented interfaces help solve this!

  ```c#
  IFlippable f1 = new Diary(1);
  IFlippable f2 = new Diary(30);
  IFlippable f3 = new Dissertation(50);
  IFlippable f4 = new Dissertation(49);

  IFlippable[] classroom = new IFlippable[] { f1, f2, f3, f4 };

  foreach (IFlippable f in classroom)
  {
    f.Flip();
  }
  ```

- Note: We can only access the functionality defined in the interface, will throw error if a property/method was not defined in the interface

## Polymorphism

- **Polymorphism** is the ability in programming to present the same interface for differing data types.

- A programming language supports _polymorphism_ if:

  1. Object of different types have a common interface, and

  2. The objects can maintain functionality unique to their data type

## Casting

- **Upcasting** is creating a superclass or interface reference from a subclass reference

- **Downcasting** is creating a subclass reference from a superclass or interface reference.

- Upcasting can be done implicitly, while downcasting cannot

  ```c#
  class Disseratation : Book, IFlippable
  {
    /* ... */
  }

  Dissertation diss = new Dissertation();
  Book bdiss = diss;
  IFlippable fdiss = diss;
  ```

- To explicitly downcast: wrap desired type in parantheses - may still fail if invalid

  ```c#
  Book bk = new Book();
  Dissertation bdk = (Dissertation)bk;
  ```

- Other ways to deal with downcasting with `as` and `is` operators available. Learn more [here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions).

## Null and Unassigned References

- A reference to no object is called either a _null reference_ or _unassigned_

- To signify that a reference is “empty” or refers to no object, we set it equal to `null`

- If a reference is not set to any value it is **unassigned** and cannot perform any operations

- Use case example:

  1. When a reference is "missing" ==> set to `null`

  ```c#
  Diary dy = null
  ```

  2. Create a reference variable without defining it ==> is 'unassigned'

  ```c#
  Diary dy;
  // dy is unassigned
  ```

  3. Initialize an empty array ==> each element is an 'unassigned reference'

  ```c#
  Diary[] diaries = new Diary[5];
  // diaries[1] is unassigned, diaries[2] is unassigned, etc.
  ```

- Checking for `null` and unassigned references:

  - Can only compare `null` reference if it is explicitly labeled `null`

    ```c#
    Diary dy = null;
    Console.WriteLine(dy == null);
    // Output: True
    ```

  - Comparing an unassigned variable will get an error

    ```c#
    Object o;
    Console.WriteLine (o == null);
    // error CS0165: Use of unassigned local variable 'o'
    ```
