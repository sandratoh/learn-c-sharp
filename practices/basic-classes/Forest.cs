using System;

namespace BasicClasses
{
  class Forest
  {
    // FIELDS -- pieces of class data
    private string name;
    // public int trees; // Can omit field when using automatic properties
    // public int age;
    private string biome;
    private static int forestsCreated; // static members pertaining only to class

    // CONSTRUCTORS
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      this.Age = 0;
      Forest.ForestsCreated++;
    }

    public Forest(string name) : this(name, "Unknown")
    {
      Console.WriteLine("Default biome value is set to be 'Unknown'");
    }

    // PROPERTIES -- provide access to fields
    // Basic property pattern
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    // Automatic properties
    public int Trees { get; set; }

    public int Age { get; private set; }

    // Basic property pattern with setter validatioin
    public string Biome
    {
      get { return biome; }
      set
      {
        switch (value)
        {
          case "Tropical":
          case "Tempearate":
          case "Boreal":
            biome = value;
            break;
          default:
            biome = "Unknown";
            break;
        }
      }
    }

    public static int ForestsCreated { get; private set; }

    // METHODS
    public int Grow()
    {
      Trees += 30;
      Age++;
      return Trees;
    }

    public int Burn()
    {
      Trees -= 20;
      Age++;
      return Trees;
    }
  }
}