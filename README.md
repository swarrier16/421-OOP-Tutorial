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
```
In this example, we see attributes for a class. At the top of the file, we see private variables CourseName and classSize. By using *get and *set, the accessors Courses and Size gain access to the private variables for their own use. Without the accessors, the data would be locked away and inaccessible to other functions. 

## **Abstraction**
With Abstraction, we are only trying to display the high-level mechanism for using it. As it is an extension of encapsulation, many of the basic ideas overlap. However, with abstraction there are many small methods that are able to call on a function without having to know how it works. 

 ## **Inheritance**
 
 ## **Polymorphism**
