using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public abstract class Appliance
    {
        //field
        private bool isElectric;

        //Property
        public bool IsElectric
        {
            get { return isElectric; }
            set { isElectric = value; }
        }

        //Constructors-NONE 

        //Methods
        public abstract void Work();

    }
}
