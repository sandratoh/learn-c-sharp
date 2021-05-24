using System;

namespace LearnInterfaces
{
  class Truck : Vehicle, IAutomobile
  {
    // Constructors
    public Truck(double speed, double weight) : base(speed)
    {
      this.Weight = weight;
      this.Wheels = Weight < 400 ? 8 : 12;
    }

    // Properties
    public double Weight { get; }

  }
}