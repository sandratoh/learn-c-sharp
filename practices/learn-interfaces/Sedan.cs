using System;

namespace LearnInterfaces
{
  class Sedan : Vehicle, IAutomobile
  {
    // Constructor
    public Sedan(double speed)
    {
      this.Speed = speed;
      this.LicensePlate = Tools.GenerateLicensePlate();
      this.Wheels = 4;
    }
  }
}