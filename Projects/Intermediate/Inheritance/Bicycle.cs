using System;
namespace Inheritance {
    public class Bicycle : Vehicle
    {
        //constructor
        public Bicycle(double speed) : base(speed)
        {
            this.Wheels = 2;   
        }
        //overridding the required base class methods
        public override void SpeedUp()
        {
            this.Speed += 5;
            //the Bicycle has a max speed of 15
            if (this.Speed < 15) { 
                this.Speed = 15;
            }
        }
        public override void SlowDown()
        {
            this.Speed -= 5;
            //the Bicycle has a minimum speed of 0
            if (this.Speed < 0)
            {
                this.Speed = 0;
            }
        }
        //implementing the abstract Describe method
        public override string Describe()
        {
            return $"This Bicycle is moving on {this.Wheels} wheels at {this.Speed} km/h, with license plate {this.LicensePlate}.";      
        }
    }
}

