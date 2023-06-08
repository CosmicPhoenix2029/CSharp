using System;
namespace RoverControlCentre;
//MoonRover and MarsRover inherit from Rover

class Program
{
    static void Main(string[] args)
    {
        //Instead of declaring each Rover Object seperately, store them in an array as below:
        //MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
        //MoonRover apollo = new MoonRover("Apollo 15", 1971);
        //MarsRover sojourner = new MarsRover("Sojourner", 1997);
        Rover[] rovers = { new MoonRover("Lunokhod 1", 1970), new MoonRover("Apollo 15", 1971), new MarsRover("Sojourner", 1997) };
        DirectAll(rovers);

        //manage all probes (rovers and satillites (both implement IDirectable))
        //Satillite sputnik = new Satillite("Sputnik", 1957);
        IDirectable[] probes = { new MoonRover("Lunokhod 1", 1970), new MoonRover("Apollo 15", 1971), new MarsRover("Sojourner", 1997), new Satillite("Sputnik", 1957) };
        //checking I constructed the array correctly:
        foreach (IDirectable probe in probes)
        {
            Console.WriteLine($"Checking type...{probe.GetType()}");    
        }
    }
    //Method for testing
    //as this isnt changing data, it can be static, and referenced without an object reference:
    public static void DirectAll(IDirectable[] probes) 
    {
        foreach (IDirectable probe in probes)
        {
            Console.WriteLine(probe.GetInfo()); 
            Console.WriteLine(probe.Explore()); 
            Console.WriteLine(probe.Collect()); 
        }
    }
}
