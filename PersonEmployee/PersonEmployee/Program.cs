using System;
using System.Collections.Generic;

namespace PersonEmployee {

    class Program {

        static void Main(string[] args) {

            // You can target multiple interfaces


            // Targetting Person 
            Person p1 = new Person("Coralie",
                                   "Sarah",
                                   "Miller",
                                   Person.Sex.FEMALE,
                                   new DateTime(1985, 5, 3));

            Console.WriteLine("p1's Full Name is: " + p1);

            // Targetting IPayable
            IPayable payable1 = new HourlyEmployee("Alyona",
                                                   "Alexandrovna",
                                                   "Ivanov",
                                                   Person.Sex.FEMALE,
                                                   new DateTime(1992, 2, 8),
                                                   "000001", 40, 62);


            Console.WriteLine(payable1 + " will be paid: " + payable1.Pay());


            // Targetting Employee
            Employee employee1 = new SalariedEmployee("Ulysses",
                                                       "S",
                                                       "Grant",
                                                       Person.Sex.MALE,
                                                       new DateTime(1972, 7, 14),
                                                       "000002",
                                                       240000.00);
         

            Console.WriteLine(employee1.FirstName + " is " +
                              employee1.Age + " years old. He will be paid $" +
                              employee1.Pay());



            // Demonstrate Static Polymorphism
            Console.WriteLine("-------------Demonstrate Overloaded Constructors----------------");

            // Overloaded Person Constructors
            // Default Constructor
            Person p2 = new Person();
            Console.WriteLine(p2);

            // Four-Argument Constructor
            Person p3 = new Person("Rick", "Warren", "Miller", Person.Sex.MALE);
            Console.WriteLine(p3);

            // Five-Argument Constructor
            Person p4 = new Person("Edgil", "Victor", "Miller", Person.Sex.MALE, new DateTime(2002, 7, 4));
            Console.WriteLine(p4);

            // Demonstrate Overloaded Operators
            Console.WriteLine("-------------Demonstrate Overloaded Operators----------------");
            Console.WriteLine("Is p2.Name older than p3.Name? {0}", p2 > p3 ? "Yes" : "No");
            Console.WriteLine("Is p2.Name younger than p3.Name? {0}", p2 < p3 ? "Yes" : "No");
            Console.WriteLine("Is p2.Name the same age as p3.Name? {0}", p2 == p3 ? "Yes" : "No");

            // Generics
            Console.WriteLine("-------------Demonstrate Generic List<IPayable>----------------");
            List<IPayable> employee_list = new List<IPayable>();
            employee_list.Add(payable1);
            employee_list.Add(employee1);

            foreach(IPayable p in employee_list) {
                Console.WriteLine(p + " will be paid: {0:C}", p.Pay());
            }


        } // End Main
    } // End class
} // End namespace
