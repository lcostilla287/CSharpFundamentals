using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public string FirstName { get; set; }

        public string LastName 
        { 
            get 
            {
                return _lastname;
            } 
            set 
            {
                _lastname = value; //value is built in this is unneeded
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}"; //we already have{} so we dont need set
            }
        }

        public int Age
        {
            get
            {
                TimeSpan agespan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = agespan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears)); //converts the previous line double to int
                return yearsOld;
            }
        }

        //backing field, last name, backing field means privately held in class
        private string _lastname { get; set;} // only exists in class

        public DateTime DateOfBirth { get; set; }

        //we are using class as a type
        public Vehicle Transport { get; set; } //class = vehicle and this uses the class as a type
    }
}
