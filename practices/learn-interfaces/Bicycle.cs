using System;

namespace LearnInheritance
{
  class Bicycle
  {
    // Constructor
    public Bicycle(double speed) : base(speed)
    {
      this.Wheels = 2;
    }

    // Method overrides
    public void SpeedUp()
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
  }
}