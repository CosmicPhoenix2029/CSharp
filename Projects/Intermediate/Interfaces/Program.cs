namespace LearnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating some car objects:
            Sedan a = new Sedan(60);
            Sedan b = new Sedan(70);
            Truck c = new Truck(45, 500);

            //show the initial stats:
            Console.WriteLine($"Sedan A:\nSpeed: {a.Speed}\nWheels: {a.Wheels}\nLicense Plate: {a.LicensePlate}\n");
            Console.WriteLine($"Sedan B:\nSpeed: {b.Speed}\nWheels: {b.Wheels}\nLicense Plate: {b.LicensePlate}\n");
            Console.WriteLine($"Truck C:\nSpeed: {c.Speed}\nWheels: {c.Wheels}\nLicense Plate: {c.LicensePlate}\n");

            //increase the speed:
            a.SpeedUp();
            b.SpeedUp();
            c.SpeedUp();

            //show the new stats:
            Console.WriteLine($"Sedan A:\nSpeed: {a.Speed}\nWheels: {a.Wheels}\nLicense Plate: {a.LicensePlate}\n");
            Console.WriteLine($"Sedan B:\nSpeed: {b.Speed}\nWheels: {b.Wheels}\nLicense Plate: {b.LicensePlate}\n");
            Console.WriteLine($"Truck C:\nSpeed: {c.Speed}\nWheels: {c.Wheels}\nLicense Plate: {c.LicensePlate}\n");
        }
    }
}