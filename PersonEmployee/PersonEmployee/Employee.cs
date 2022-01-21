/*************************************************
* The Employee class extends Person and implements
* IPayable, but since it defers the actual
* implementation of IPayable's Pay() method
* to derived classes it must be declared an
* abstract class.
**************************************************/
using System;

namespace PersonEmployee {

    public abstract class Employee : Person, IPayable {

        private String _employeeNumber;

        public String EmployeeNumber {
            get { return _employeeNumber; }
            set { _employeeNumber = value; }
        }

        public Employee(String firstName, String middleName, String lastName,
                        Sex gender, DateTime birthday, String employeeNumber) :
                        base(firstName, middleName, lastName, gender, birthday) {
            _employeeNumber = employeeNumber;
        }


        public abstract double Pay(); // map IPayable.Pay() to an abstract method 
                                      // and defer implementation

    } // End Employee
} // End namespace
