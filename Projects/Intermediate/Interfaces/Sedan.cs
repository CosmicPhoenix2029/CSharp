namespace Interfaces
{
    //defining a class that implements the interface IAutomobile
    public class Sedan : IAutomobile
    {
        //defining the interfaces members:
        public string LicensePlate { get; }
        public double Speed { get; private set; }
        public int Wheels { get; }

        //constructor
        public Sedan(double speed)
        {
            this.Speed = speed;
            this.Wheels = 4;
            this.LicensePlate = "RZ43 QBC";
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
