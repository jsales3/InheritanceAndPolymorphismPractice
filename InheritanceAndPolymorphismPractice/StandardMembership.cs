using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class StandardMembership: Membership
    {
        //fields
        //invisible

        //Properties
        public int Cost { get; set; }

        //Constructor
        public StandardMembership()
        {
            //default constructor
        }

        public StandardMembership(int cost)
        {
            Cost = cost;
        }

        //Methods
        public override void Activate()
        {
            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("your standard membership has been activated");
            }
            else
            {
                Console.WriteLine("Standard membership is already active");
            }
        }
    }

}
