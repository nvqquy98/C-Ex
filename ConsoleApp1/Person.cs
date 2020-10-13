using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        public string name { get; set; }
        public double salary { get; set; }
        public Person(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        
        public static bool isCompareSalary(object o1,object o2)
        {
            if (((Person)o1).salary < ((Person)o2).salary) return true;
            return false;
        }

        public static bool isCompareName(object o1, object o2)
        {
            string s1 = ((Person)o1).name;
            string s2 = ((Person)o2).name;
            if (s1.CompareTo(s2) <= 0) return true;
            return false;
        }
    }
}
