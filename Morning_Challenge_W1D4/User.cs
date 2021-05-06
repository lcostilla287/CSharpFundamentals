using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Morning_Challenge_W1D4
{
    [TestClass]
    public class User
    {
        public User(string firstName, string lastName, int id, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;                //filled constructor
            Birthday = date;
        }
        public int CalculateAge
        {
            get
            {
            TimeSpan ageSpan = DateTime.Now - Birthday;
                double ageInDays = ageSpan.TotalDays;  //This thing converts the age into years!!!
                double ageInYears = ageInDays / 365;
                int years = Convert.ToInt32(Math.Floor(ageInYears)); //int is used on both sides so that it can be an int
                return years;
            }
        }

        public string FullName() // can also do this for fullname
        {
            return $"{FirstName} {LastName}"; //calls on this particular method
        }

        public User() { } //blank constructor

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int ID { get; private set; }
        public DateTime Birthday { get; private set; }
    }
}
