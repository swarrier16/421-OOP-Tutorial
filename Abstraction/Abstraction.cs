using System;

namespace Abstraction
{
    public class Abstracting
    {
        abstract class Majors //abstract class
        {
            public abstract int GetGPA(); //abstract method
        }

        class CS : Majors
        {
            private int grade;
            public CS(int g)
            {
                grade = g;
            }
            public override int GetGPA()
            {
                return grade;
            }
        }

        class English : Majors
        {
            private int grade;
            public English(int g)
            {
                grade = g;
            }
            public override int GetGPA()
            {
                return grade;
            }
        }
    }
}