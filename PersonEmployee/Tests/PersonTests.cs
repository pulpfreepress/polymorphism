using NUnit.Framework;
using System;
using PersonEmployee;

namespace Tests {

    public class PersonTests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void DateOfBirthTests() {

            DateTime today = DateTime.Today;
          
            // Born 30 years ago today
            DateTime birthday = today.AddYears(-30);
           

            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();

            p1.DateOfBirth = new DateTime(birthday.Year, birthday.Month, birthday.Day);

            p2.DateOfBirth = new DateTime(birthday.Year, birthday.AddMonths(1).Month, birthday.Day);
            

            p3.DateOfBirth = new DateTime(birthday.Year, birthday.Month, birthday.AddDays(-1).Day);

            Assert.AreEqual(p1.Age, 30);
            Assert.AreEqual(p2.Age, 29);
            Assert.AreEqual(p3.Age, 30);
           
        }
    }
}
