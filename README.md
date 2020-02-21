# 421-OOP-Tutorial

When it comes to Object-Oriented Programming (OOP), there are 4 main principles: **Encapsulation, Abstraction, Inheritance,** and **Polymorphism**. It is important to have a good understanding of these principles if you want to write a program that functions properly. 

This tutorial will go over examples of each principal in C#, starting with encapsulation.

## **Encapsulation**

Encapsulation is the idea that a program has different methods which communicate with each other, but each method has its own private components. Think of it like a protective shield that wraps around the data from being accessed from the outside. Let's examine the code below:

```
using System;

namespace Encapsulation
{
    public class Course
    {
        private String CourseName; //private variables initialized
        private int classSize; 

        public string Courses
        {
        //accessor that allows access to the private variables
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
```
In this example, we see attributes for a class. At the top of the file, we see private variables CourseName and classSize. By using _get_ and _set_, the accessors Courses and Size gain access to the private variables for their own use. Without the accessors, the data would be locked away and inaccessible to other functions. 

## **Abstraction**
With Abstraction, we are only trying to display the high-level mechanism for using it. As it is an extension of encapsulation, many of the basic ideas overlap. However, with abstraction there are many small methods that are able to call on a function without having to know how it works. 
```
using System;

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
```
Here we have the abstract class Major, and we want to store all the GPAs for each major. We create an instance of majors CS and English, which share common attributes but call on variables that are available within their own subclasses. However, for the main abstract class, we are only concerned with the GPA across all majors, and not really what goes on inside each individual major. It only reveals the operation relevant to the other methods included. 

 ## **Inheritance**
 Inheritance allows us to create a class that acts as a _child_ of an existing class. Basically, it inherits any properties of its parent, but can expand from there. Each child only adds what it needs to. Let us examine the example below.
 ```
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

        public class Rectangle : Shape //Rectangle extends Shape
        {
            public double Perimeter(double width, double height) //return perimeter of rectangle
            {
                return 2 * width + 2 * height;
            }

            public double Area(double width, double height) //return area of rectangle
            {
                return width * height;
            }
           

        }
   
}
```
Here we have parent class Shape. Its child Rectangle takes in the properties of shape (After all, rectangles are shapes, right?). Rectangle then extends shape and inherits the values for width and height. From here, we can calculate the perimeter and area of the rectangle!
 
 ## **Polymorphism**
The final principal is polymorphism. Polymorphism means "many shapes", so based off of that we can say that polymorphism takes one object and shifts into many different versions of itself. Input is taken in by the system and then evaluated to fit in the correct function. 
```
using System;

namespace Polymorphism
{
    public class polymorphism
    {
        
            public int Sum(int a, int b)
            {
                var sum = a + b;
                return sum;
            }

            public double Sum(double a, double b)
            {
                var sum = a + b;
                return sum;
            }

        
    }
}
```
For example, we can have multiple methods called Sum. If the system receives integers as input, the compiler will implement the first Sum function. It will keep searching until it finds an appropriate method to execute the query. 

