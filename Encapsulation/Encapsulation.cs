using System;

namespace Encapsulation
{
    public class Course
    {
        private String CourseName;
        private int classSize;

        public string Courses
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

        public int Size
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
    
}
