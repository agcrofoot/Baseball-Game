using System;

namespace _221StarterCode
{
    public class Lefty : Pitcher
    {
        public Lefty()
        {
            Throws = "Left";
            SetPitchBehavior(new Curveball());
        }

    }
}