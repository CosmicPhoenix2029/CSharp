namespace Inheritance
{
    //defining a class that extends the Vehicle class, and also implements the interface IAutomobile
    public class Sedan : Vehicle, IAutomobile
    {
        //constructor
        public Sedan(double speed) : base(speed)
        {
            this.Wheels = 4;
        }
        //implementing the abstract Describe method
        public override string Describe()
        {
            return $"This Sedan is moving on {this.Wheels} wheels at {this.Speed} km/h, with license plate {this.LicensePlate}.";
        }
    }
}
