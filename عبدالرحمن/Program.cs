// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
class Person
{
    public string Name;
    public virtual void Displaylnfo()
    {
        Console.WriteLine($" Name: {Name}");
    }


class Student : Person
    {
        public string StudentId;
        public override void Displaylnfo()
        {
            Console.WriteLine($"Name:{Name},student ID:{StudentId}");
        }
   
    
      
    }

class Employee : Person
    {
        public double Salary;
        public override void Displaylnfo()
        {
            Console.WriteLine($"Name:{Name},student ID:{Salary}");
        }
    }

class Teacher : Person
    {
        public string CourseName;
        public override void Displaylnfo()
        {
            Console.WriteLine($"Name:{Name},student ID:{CourseName}");

        }


    


class Program
        {

        }
