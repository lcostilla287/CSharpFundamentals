using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenge_W1D5
{

    public enum CourseType { Cyber_Security, Software_Development, Web_Development }

    public enum BadgeType { White_Badge, Gold_Badge, Red_Badge, Blue_Badge }
    public class Student
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth, CourseType classTaking, decimal balanceOwed, BadgeType typeOfBadge, bool hasGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;  //this has all of the stuff i need
            ClassTaking = classTaking;
            BalanceOwed = balanceOwed;
            TypeOfBadge = typeOfBadge;
            HasGraduated = hasGraduated;

        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CourseType ClassTaking { get; set; }
        public decimal BalanceOwed { get; set; }
        public BadgeType TypeOfBadge { get; set; }
        public bool HasGraduated { get; set; }
        public Student() { } // this is my empty constructor and overloaded
    }

    public enum CourseTaught { Cyber, Web_Dev, Software_Dev }
    class Instructor
    {
        public Instructor(string firstName, string lastName, DateTime dateOfBirth, int employeeNumber, CourseTaught courseTaught)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            EmployeeNumber = employeeNumber;
            TaughtCourse = courseTaught;

        }

        public string FirstName { get; set;}
        public string LastName { get; set;}
        public DateTime DateOfBirth { get; set; }
        public int EmployeeNumber { get; set; }
        public CourseTaught TaughtCourse { get; set; }

        public Instructor() { }

        public Instructor (int employeeId)
        {
            IdOfEmployee = employeeId;
        }

        public int IdOfEmployee { get; } //this makes sure that the employee id can't be changed only recieved 

    }
}
