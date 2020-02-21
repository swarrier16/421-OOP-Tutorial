using System;

namespace Inheritance
{
      public class Shape
        {
            public void setAttributes(double w, double h)
            {
                width = w;
                height = h;
            }

        protected double width;
        protected double height;

        }

        public class Rectangle : Shape
        {
            public double Perimeter(double width, double height) //return perimeter of rectangle
            {
                return 2 * width + 2 * height;
            }

            public double Area(double width, double height) //return area of rectangle
            {
                return width * height;
            }
            // Display a triangle's style.  

        }
   // }
}

