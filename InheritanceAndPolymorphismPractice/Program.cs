using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //StandardMembership gymMembership1 = new StandardMembership(100);
            //VIPMembership gymMembership2 = new VIPMembership();

            //gymMembership1.Activate();
            //gymMembership2.Activate();

            Microwave myMicrowave = new Microwave(1000, "samsung");
            Dishwasher myDishwasher = new Dishwasher(0, true);

            myMicrowave.Work();
            myDishwasher.Work();
        }
    }
}
