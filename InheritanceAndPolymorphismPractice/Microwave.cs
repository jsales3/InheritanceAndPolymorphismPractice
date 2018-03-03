﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Microwave: Appliance
    {
        //fields
        private int watts;
        private string brand;
        
        //Properties
        public int Watts
        {
            get { return watts; }
            set { watts = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        //Constructors
        public Microwave()
        {
            //default constructor
        }

        public Microwave(int watts, string brand)
        {
            this.watts = watts;
            this.brand = brand;

        }

        //Methods
        public override void Work()
        {
            Console.WriteLine("I emit radioactive waves");
            Console.WriteLine("I heat up your food");
        }
       
    }

}
