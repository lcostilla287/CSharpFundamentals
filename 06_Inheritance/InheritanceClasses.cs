using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public abstract class Person  //abstract means it is only for inheritance
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}"; //this returns the fullname so no set is needed
            }
        }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person () { } //empty

        public Person(string firstName, string lastName, string phoneNumber, string email) //we don't need full name because we already did the thing before
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public abstract void WhoAmI(); // this is section a method!! virtual means we can override it later
       // {
         //   Console.WriteLine("I am a person");
        //}
    }

    public class Customer : Person //inheritance (use the stuff before in the person class)
    {
        public bool IsPremium { get; set; }

        public Customer() { }
        public Customer(bool isPremium)
        {
            IsPremium = isPremium;
        }

        public override void WhoAmI()
        {
           // base.WhoAmI();
            Console.WriteLine("I am a customer");
        }
    }
    
    public class Employee : Person
    { 
        public Employee(int employeeNumber) 
        {
            EmployeeNumber = employeeNumber;
        }
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsWithCompany 
        {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.25;  //totaldays is a double, this conversion is easier.
                return Convert.ToInt32(Math.Floor(totalTime));
            }
        } 

        public Employee(int employeeNumber, DateTime hireDate, string firstName, string lastName, string phoneNumber, string email) : base (firstName, lastName, phoneNumber, email) //use this to inherit these things from person
        {
            EmployeeNumber = employeeNumber;
            HireDate = hireDate;
        }

        public override void WhoAmI() // this calls the virtual method way above
        {
            Console.WriteLine("I am an employee"); //we have to declare a body if our virtual is abstract
            //base.WhoAmI();
        }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public SalaryEmployee(int employeeNumber, decimal salary) : base(employeeNumber) //this inherits the one with only the employeeNumber
        {
            Salary = salary;
        }
    }
}
