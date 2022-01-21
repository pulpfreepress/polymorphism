/***************************************************
 * 
 * The Person class represents a person entity. 
 * 
 * ************************************************/
using System;

namespace PersonEmployee {

    public class Person {

        //enumeration
        public enum Sex { MALE, FEMALE }

        // Private Fields
        private DateTime _dob;

        public string FirstName {
            get;
            set;
        }

        public string MiddleName {
            get;
            set;
        }

        public String LastName {
            get;
            set;
        }

        public Sex Gender {
            get;
            set;
        }

        public DateTime DateOfBirth {
            get => _dob;
            set {

                if (value <= DateTime.Now) {
                    _dob = value;
                }
                else {
                    throw new ArgumentOutOfRangeException("Invalid Date of Birth provided!");
                }
            }
        }

        public int Age {
            get {
                int years_old = DateTime.Now.Year - DateOfBirth.Year;

                if (DateTime.Now.Month < DateOfBirth.Month) {
                    years_old -= 1;
                }
                else if ((DateTime.Now.Month <= DateOfBirth.Month) && (DateTime.Now.Day < DateOfBirth.Day)) {
                    years_old -= 1;
                }

                return years_old;
            }
        }

        // Overloaded Constructors
        // Default Constructor
        public Person() : this("John", "J", "Doe", Sex.MALE, DateTime.Now) { }

        // Four-Argument Constructor
        public Person(string firstName,
                      string middleName,
                      string lastName,
                      Sex gender) : this(firstName, middleName, lastName, gender, DateTime.Now) { }

        // Five-Argument Constructor
        public Person(string firstName,
                      string middleName,
                      string lastName,
                      Sex gender,
                      DateTime dateOfBirth) {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }

        // Override Object.ToString()
        public override string ToString() {
            return FirstName + " " + MiddleName + " " + LastName + " | " + Gender +
                   " | Born: " + DateOfBirth.ToShortDateString() + " | Age: " + Age;
        }


        // Overload Operators <= and >=
        public static bool operator <=(Person lhs, Person rhs) {
            return lhs.Age <= rhs.Age;
        }

        public static bool operator >=(Person lhs, Person rhs) {
            return lhs.Age >= rhs.Age;
        }

        // Overload Operators < and >
        public static bool operator <(Person lhs, Person rhs) {
            return lhs.Age < rhs.Age;
        }

        public static bool operator >(Person lhs, Person rhs) {
            return lhs.Age > rhs.Age;
        }

        // Overload Operators == and !=
        public static bool operator ==(Person lhs, Person rhs) {
            return lhs.Age == rhs.Age;
        }

        public static bool operator !=(Person lhs, Person rhs) {
            return lhs.Age != rhs.Age;
        }

    } // End Person

} // End namespace


