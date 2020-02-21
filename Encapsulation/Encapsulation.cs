using System;

namespace Encapsulation
{
    public class Course
    {
        
        public string CourseName
        {
            get
            {
                return CourseName;
            }
            set
            {
                CourseName = value;
            }
        }

        public int classSize
        {

            get
            {
                return classSize;
            }

            set
            {
                classSize = value;
            }

        }
    }
    class Driver
    {

        // Main Method 
        static public void Main()
        {
            Course c = new Course();
            c.CourseName = "Math";
            c.classSize = 21;
        }
    }
}
