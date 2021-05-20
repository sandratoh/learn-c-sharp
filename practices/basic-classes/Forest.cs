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

    // CONSTRUCTOR METHOD
    public Forest(string name, string biome)
    {
      Name = name;
      Biome = biome;
      Age = 0;
    }

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