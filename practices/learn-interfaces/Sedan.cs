using System;

namespace LearnInterfaces
{
  class Sedan : IAutomobile
  {
    // Interface members
    public string LicensePlate { get; }
    public double Speed { get; }
    public int Wheels { get; }
    public void Honk()
    {
      Console.WriteLine("Honk!");
    }

    // Constructor
    public Sedan(double speed)
    {
      this.Speed = speed;
      this.LicensePlate = Tools.GenerateLicensePlate();
      this.Wheels = 4;
    }

    // Methods
    public Sedan(double speed)
    {
      this.Speed = speed;
      this.LicensePlate = Tools.GenerateLicensePlate();
      this.Wheels = 4;
    }
  }
}