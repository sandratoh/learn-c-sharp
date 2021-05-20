using System;

namespace BasicClasses
{
  class Forest
  {
    // Fields -- pieces of class data
    public string name;
    public int trees;
    public int age;
    public string biome;

    // Property -- provide access to fields
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Trees
    {
      get { return trees; }
      set { trees = value; }
    }

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