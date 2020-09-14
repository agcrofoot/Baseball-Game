using System;

namespace _221StarterCode
{
    public class Pitcher
    {
        public string Name{get; set;}
        public string Team{get; set;}
        public string Throws{get; set;}
        public virtual void Pitch()
        {
            Console.WriteLine("The pitch has been thrown.");
        }
    }
}