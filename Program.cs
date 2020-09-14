using System;
using System.Collections.Generic;
using System.IO;

namespace _221StarterCode
{
    class Program
    {
        static void Main(string[] args)
        {
            IPitch fastball = new Fastball();
            IPitch curve = new Curveball();
            IPitch slider = new Slider();

            Pitcher craftyLefty = new Lefty(){Name = "Krafty", Team = "Mets"};

            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a strike.");

            craftyLefty.SetPitchBehavior(fastball);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a strike");

            craftyLefty.SetPitchBehavior(slider);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a ball");

            craftyLefty.SetPitchBehavior(curve);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("Strike 3, Batter is out");

        }
    }
}
