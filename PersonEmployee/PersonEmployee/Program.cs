using System;

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

        } // End Main
    } // End class
} // End namespace
