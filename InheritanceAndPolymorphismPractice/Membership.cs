using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Membership
    {
        //fields
        private int memberID;
        private bool isActive;


        //Properties
        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        //constructors
        public Membership()
        {
            //default constructor
        }

        public Membership(int memberID, bool isActive)
        {
            this.memberID = memberID;
            this.isActive = isActive;
        }

        public virtual void Activate()
        {
            if(isActive == false)
            {
                isActive = true;
                Console.WriteLine("your membership has been activated");
            }
            else
            {
                Console.WriteLine("membership is already active");
            }
        }
    }

}
