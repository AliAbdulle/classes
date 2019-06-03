using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        //Create a custom type for Employee. An employee has the following properties.
        public string CompanyName { get; set; }
        public DateTime DateFound { get; set; }

        // public List<Employee> ListOfEmployees { get; set; }


        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string companyName, DateTime dateFound)
        {
            CompanyName = companyName;
            DateFound = dateFound;
        }
        List<Employee> ListOfEmployees = new List<Employee>()
        {

        };
        public void addEmployee(Employee employee)
        {
            ListOfEmployees.Add(employee);
        }
        public void ListOfEmployeesDetail()
        {
            foreach (Employee employee in ListOfEmployees)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName} worked the {CompanyName} as {employee.title} since {employee.startDate}");
            }
        }
    }
}