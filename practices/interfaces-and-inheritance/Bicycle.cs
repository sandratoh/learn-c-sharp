using System;

namespace InterfacesAndInheritance
{
  class Bicycle : Vehicle
  {
    // Constructor
    public Bicycle(double speed) : base(speed)
    {
      this.Wheels = 2;
    }

    // Method overrides
    public override void SpeedUp()
    {
      Speed += 5;
      if (Speed > 15)
      {
        Speed = 15;
      }
    }

    public override void SlowDown()
    {
      Speed -= 5;
      if (Speed < 0)
      {
        Speed = 0;
      }
    }

    public override string Describe()
    {
      return $"This bicycle is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
    }
  }
}