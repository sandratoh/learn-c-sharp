using System;

namespace LearnInterfaces
{
  class Truck : Vehicle, IAutomobile
  {
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

  }
}