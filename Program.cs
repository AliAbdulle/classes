using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
           Company Token = new Company("Token, LLC", new DateTime(2/28/2019));

           Employee Ali = new Employee()
           {
               firstName = "Ali",
               lastName = "Abdulle",
               title = "Software Developer",
               startDate = new DateTime(2019, 2, 18)
           };
             Employee Anthony = new Employee()
           {
               firstName = "Anthony",
               lastName = "Neiler",
               title = "IT Manger",
               startDate = new DateTime(2017, 2, 8)
           };
             Employee David = new Employee()
           {
               firstName = "David",
               lastName = "Roller",
               title = "Logistic Manager",
               startDate = new DateTime(2010, 10, 12)
           };

           Token.addEmployee(Ali);
           Token.addEmployee(Anthony);
           Token.addEmployee(David);
           Token.ListOfEmployeesDetail();

        }
    }
}
