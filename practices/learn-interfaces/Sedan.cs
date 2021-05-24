using System;

namespace LearnInterfaces
{
  class Sedan : Vehicle, IAutomobile
  {
    // Constructor
    public Sedan(double speed) : base(speed)
    {
      this.Wheels = 4;
    }

    // Methods
    public override string Describe()
    {
      return $"This sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
    }
  }
}