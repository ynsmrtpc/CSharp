using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[1]
                {
                    new Student() { Id = 2 ,FirstName = " Emre " , Department = "Software"},
                };

            Customer[] customer = new Customer[1]
            {
                new Customer() { Id = 1 ,FirstName = " Yunus ", City =  "Istanbul"},

            };
        

            Person[] persons = new Person[3]
            {
                new Customer() { Id = 1 ,FirstName = " Yunus ", City =  "Istanbul"},
                new Student() { Id = 2 ,FirstName = " Emre " , Department = "Software"},
                new Person() { Id = 3 ,FirstName = " Topçu ", LastName = "..."}
            };



            foreach (var person in persons)
            {
                Console.Write(person.Id);
                Console.WriteLine(person.FirstName + person.LastName);
            }

            foreach (var students in student)
            {
                Console.WriteLine("\n" + students.Department);
            }

            foreach (var customers in customer)
            {
                Console.WriteLine("\n" + customers.City);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
