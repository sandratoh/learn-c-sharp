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

    // Methods
    public override string Describe()
    {
      return $"This truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
    }
  }
}