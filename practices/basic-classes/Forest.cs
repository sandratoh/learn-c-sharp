using System;

namespace BasicClasses
{
  class Forest
  {
    // Fields -- pieces of class data
    public string name;
    // public int trees; // Can omit field when using automatic properties
    public int age;
    public string biome;

    // Property -- provide access to fields

    // Basic property pattern
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    // Automatic properties
    public int Trees { get; set; }

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
  }
}