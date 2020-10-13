using System;

namespace ConsoleApp1
{
    public delegate bool CompareObj(object o1, object o2);
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person[] persons = new Person[4];
            persons[0] = new Person("Quy Mui", 2004);
           
            persons[1] = new Person("Ha Giang", 1978);
           
            persons[2] = new Person("Ngoc Thao", 1979);
           
            persons[3] = new Person("Ha Nam", 1932);
            CompareObj cmp = new CompareObj(Person.isCompareSalary);
            ASort.Sort(persons, cmp);

        }
    }
}
