using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Shape
    {
        //fields
        private int sides;

        //properties
        public int Side
        {
            get { return sides; }
            set { Side = value; }
        }

        //constructors
        public Shape()
        {
            //default constructor
        }

        public Shape(int sides)
        {
            this.sides = sides;
        }

        //Methods

        public class Rectangle : Shape
        {
            private double area;

            public double Area
            {
                get { return this.area; }
                set { this.area = value; }
            }

            public Rectangle(double area)
            {
                this.area = area;
            }

            
        }
    }

}
