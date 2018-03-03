using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class VIPMembership:Membership
    {
        //fields
        //invisible

        //Properties
        public bool IsSwanky { get; set; }

        //Constructors
        public VIPMembership()
        {
            //default constructors
        }

        public VIPMembership(bool isSwanky)
        {
            IsSwanky = isSwanky;
            
        }

        //Methods
        public override void Activate()
        {
            IsSwanky = true;

            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("you are now a big deal");
            }
            else
            {
                Console.WriteLine("your already a big deal");
            }
        }
    }
}
