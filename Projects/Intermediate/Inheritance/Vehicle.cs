using System;
namespace Inheritance 
{
    //this is an abstract class, meaning an object cannot be created from it, and it is solely to serve as a base class for subclasses to inherit from.
    public abstract class Vehicle : IAutomobile
    {
        //properties (use protected if the properties need to be accessed by a subclass)
        public string LicensePlate { get; private set; }
        public double Speed { get; protected set; }
        public int Wheels { get; protected set; }

        //constructor (which creates the object with the shared attributes of both the truck and sedan class)
        public Vehicle(double speed)
        {
            LicensePlate = "AB12 3CD";
            Speed = speed;
        }

        //methods
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
        //using virtual to allow the method to be overridden by subclasses
        public virtual void SpeedUp()
        {
            this.Speed += 5;
        }
        public virtual void SlowDown()
        {
            this.Speed -= 5;
        }

        //an abstract method needs to be implemented by each subclass - note there is no body as it can only be implemented from a subclass
        public abstract string Describe();

    }
}