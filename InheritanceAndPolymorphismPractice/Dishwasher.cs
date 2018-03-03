using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Dishwasher:Appliance
    {
        //fields
        //invisible

        //properties
        public double DecibelLevel { get; set; }
        public bool HasHeatDry { get; set; }

        //construstors
        public Dishwasher()
        {
            //default constructor
        }

        public Dishwasher(double decibelLevel, bool hasHeatDry)
        {
            DecibelLevel = decibelLevel;
            HasHeatDry = hasHeatDry;
        }

        //Methods
        public override void Work()
        {
            Console.WriteLine("I was your dishes.");
            Console.WriteLine("wash wash wash");
        }
    }
}
