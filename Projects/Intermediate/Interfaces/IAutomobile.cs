using System;

namespace Interfaces
{
    //defining an interface (define the methods and properties here, ready for implementation by the implementing class)
    interface IAutomobile
    {
        //properties
        string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }

        //methods
        void Honk();
    }
}