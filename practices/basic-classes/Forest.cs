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
    private static string treeFacts;

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

    // Static constructor
    static Forest()
    {
      Forest.treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
      Forest.ForestsCreated = 0;
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

    // Basic property pattern with setter validation
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

    // Static property
    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }
    public static string TreeFacts { get; }

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

    // Static methods
    public static void PrintTreeFacts()
    {
      Console.WriteLine(Forest.TreeFacts);
    }
  }
}