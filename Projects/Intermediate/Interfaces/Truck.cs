namespace Interfaces 
{
    public class Truck : IAutomobile
    {
        //defining the interfaces properties:
        public string LicensePlate { get; }
        public double Speed { get; private set; }
        public int Wheels { get; }

        //class properties:
        public double Weight { get; }
        //constructor
        public Truck(double speed, double weight)
        {
            this.Speed = speed;
            this.Weight = weight;
            this.LicensePlate = "AB94 QBC";
            //if weight is less than 400, 8 wheels, otherwise 12
            this.Wheels = (this.Weight < 400) ? 8 : 12;
        }

        //Interface methods
        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        //class methods
        public void SpeedUp()
        {
            this.Speed += 5;
        }

        public void SlowDown()
        {
            this.Speed -= 5;
        }
    }
}


