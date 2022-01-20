/***************************************************
 * 
 * SalariedEmployee extends Employee and implements
 * the Pay() method from the IPayable interface.
 * 
 * ************************************************/

using System;
namespace PersonEmployee {
    public class SalariedEmployee : Employee {

        private double _salary;

        public double Salary {
            get { return _salary; }
            set { _salary = value; }
        }

        public SalariedEmployee(String firstName, String middleName, String lastName,
                    Sex gender, DateTime birthday, String employeeNumber, double salary) :
                    base(firstName, middleName, lastName, gender, birthday, employeeNumber) {
            _salary = salary;

        }

        public override double Pay() {
            return _salary / 24;
        }

    } // End class
} // End namespace
