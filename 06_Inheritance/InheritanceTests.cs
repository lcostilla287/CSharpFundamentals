using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonTests()
        {
            //Person larry = new Person(); because we have an abstract this section can't be used
            //larry.FirstName = "Larry";
            //larry.LastName = "Bird";
            //Console.WriteLine(larry.FullName); // we can do this because we have it set to return in the properties

            Customer sal = new Customer();
            sal.FirstName = "Sal";
            sal.LastName = "Vulcano";
            sal.IsPremium = true;
            Console.WriteLine(sal.FullName);
            Console.WriteLine(sal.IsPremium);

            sal.WhoAmI(); //virtual override stuff

            Employee joe = new Employee(2, new DateTime(2021, 01, 01), "Joe", "Smith", "1234567890", "joeyG@gmail.com");
            Console.WriteLine(joe.Email);
            joe.WhoAmI();


            SalaryEmployee brian = new SalaryEmployee(3, 500000);
            brian.FirstName = "Brian";
            brian.LastName = "Quinn"; //these are not neccesary because we only want the salary in this case

            List<Person> people = new List<Person>();
            people.Add(sal);
           // people.Add(larry);
            people.Add(joe);
            people.Add(brian);  //We can do all of this because they inherit properties of person

            foreach(Person person in people) //pay attention to the syntax!! This comes from the list above
            {
                Console.WriteLine(person.FullName);
            }
        }
    }
}
