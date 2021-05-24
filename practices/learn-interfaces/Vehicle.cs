using System;

namespace LearnInheritance
{
  class Vehicle
  {
    public string LicensePlate { get; protected set; }
    public double Speed { get; protected set; }
    public int Wheels { get; protected set; }

    // Constructor
    public Vehicle(double speed)
    {
      this.Speed = speed;
      this.LicensePlate = Tools.GenerateLicensePlate();
    }

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

