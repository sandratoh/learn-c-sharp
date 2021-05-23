using System;

namespace LearnInheritance
{
  class Vehicle
  {
    public string LicensePlate { get; protected set; }
    public double Speed { get; protected set; }
    public int Wheels { get; protected set; }

    // Methods
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }
  }
}

