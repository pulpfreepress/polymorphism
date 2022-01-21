/***************************************************
 * 
 * HourlyEmployee extends Employee and implements
 * the Pay() method from the IPayable interface.
 * 
 * ************************************************/
using System;

namespace PersonEmployee {

    public class HourlyEmployee : Employee {

        private int _hoursWorked;
        private double _hourlyWage;

        public int HoursWorked {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        public double HourlyWage {
            get { return _hourlyWage; }
            set { _hourlyWage = value; }
        }

        public HourlyEmployee(String firstName, String middleName, String lastName,
                    Sex gender, DateTime birthday, String employeeNumber, int hoursWorked,
                    double hourlyWage) : base(firstName, middleName, lastName, gender, birthday,
                    employeeNumber) {
            _hoursWorked = hoursWorked;
            _hourlyWage = hourlyWage;
        }

        public override double Pay() {
            return _hoursWorked * _hourlyWage;
        }

    } // End class
} // End namespace
