using System;

namespace InterfacesAndInheritance
{
  abstract class Vehicle
  {
    public string LicensePlate { get; protected set; }
    public double Speed { get; protected set; }
    public int Wheels { get; protected set; }

    // Constructor
    public Vehicle(double speed)
    {
      this.Speed = speed;
      this.LicensePlate = Tools.GenerateLicensePlate();
    }

    // Methods
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    // Virtual/overridable methods
    public virtual void SpeedUp()
    {
      Speed += 5;
    }

    public virtual void SlowDown()
    {
      Speed -= 5;
    }

    // Abstract method
    public abstract string Describe();
  }
}

