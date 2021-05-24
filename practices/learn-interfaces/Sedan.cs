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
  }
}