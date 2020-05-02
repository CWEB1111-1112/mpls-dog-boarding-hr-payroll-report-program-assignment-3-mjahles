using System;
using System.Collections.Generic;
/**
Name: Matt Ahles
Date of completion: 5/1/2020

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            string firstName;
            string lastName;
            int departmentNumber;
            int salary;
            int hoursWorked;
            const string END = "999";
            
            List<Info> employeeInfoList = new List<Info>();
        }
    }
    //Separate class used for making the List type
    class Info
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        public int departmentNumber {get; set;}
        public int salary {get; set;}
        public int hoursWorked {get; set;}

        public Info(string firstName, string lastName, int departmentNumber, int salary, int hoursWorked)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.departmentNumber = departmentNumber;
            this.salary = salary;
            this.hoursWorked = hoursWorked;
        }
    }
}
