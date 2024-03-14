using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class C8Corvette : RaceCar
    {
        public C8Corvette()
        {
            Name = "Corvette Stringray";
            TopSpeed = 194;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} looking to show who's the boss!");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name}: With the engine quiet, take a moment to appreciate the places you've been and the roads you've conquered.");
        }
    }
}
