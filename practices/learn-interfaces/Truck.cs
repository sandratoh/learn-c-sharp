using System;

namespace LearnInterfaces
{
  class Truck : IAutomobile
  {
    // Interface members
    public string LicensePlate { get; }
    public double Speed { get; private set; }
    public int Wheels { get; }
    public void Honk()
    {
      Console.WriteLine("HONKS!");
    }

    // Constructors
    public Truck(double speed, double weight)
    {
      this.Speed = speed;
      this.Weight = weight;
      this.LicensePlate = Tools.GenerateLicensePlate();
      this.Wheels = Weight < 400 ? 8 : 12;
    }

    // Properties
    public double Weight { get; }

    // Methods
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