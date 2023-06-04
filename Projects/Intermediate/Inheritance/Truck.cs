namespace Inheritance
{
    public class Truck : Vehicle, IAutomobile
    {
        //class properties:
        public double Weight { get; }
        //constructor (this also refers to the superclass )
        public Truck(double speed, double weight) : base(speed)
        {
            this.Weight = weight;
            //if weight is less than 400, 8 wheels, otherwise 12
            this.Wheels = (this.Weight < 400) ? 8 : 12;
        }
        //implementing the abstract Describe method
        public override string Describe()
        {
            return $"This Truck is moving on {this.Wheels} wheels at {this.Speed} km/h, with license plate {this.LicensePlate}.";
        }

    }
}


