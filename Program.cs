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
            string firstName = "";
            string lastName;
            int departmentNumber;
            double salary;
            int hoursWorked;
            const string END = "999";
            double grossSalary;
            string [] departmentName = {"Personnel", "Marketing", "Information Technology", "Computer Services", "Sales", "Legal", "Accounting"};
            double [] departmentSalary = {0, 0, 0, 0, 0, 0, 0,};
            int x = 0;
            
            //List that contains employee info object instances
            List<Info> employeeInfoList = new List<Info>();

            //Intake of employee info
            while(x < x + 1){
                x++;
                Console.WriteLine("Please input the Employee's first name (input 999 to exit):");
                firstName = Console.ReadLine();
                if(firstName != END){    
                    Console.WriteLine("Please input the Employee's last name:");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Please input the Employee's department number:");
                    Console.WriteLine("Personnel [1], Marketing [2], Information Technology [3], Computer Services [4], Sales [5], Legal [6], Accounting [7]");
                    departmentNumber = Convert.ToInt32(Console.ReadLine());
                        //Defensive programming to ensure correct department number
                        while(departmentNumber !=1 && departmentNumber !=2 && departmentNumber !=3 && departmentNumber !=4 && departmentNumber !=5 && departmentNumber !=6 && departmentNumber !=7){
                            Console.WriteLine("Please input a valid Department number:");
                            Console.WriteLine("Personnel [1], Marketing [2], Information Technology [3], Computer Services [4], Sales [5], Legal [6], Accounting [7]");
                            departmentNumber = Convert.ToInt32(Console.ReadLine());
                        }
                    Console.WriteLine("Please input the Employee's salary:");
                    salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please input the Employee's hours worked:");
                    hoursWorked = Convert.ToInt32(Console.ReadLine());
                    grossSalary = hoursWorked * salary;
                    
                    Info anEmployee = new Info(firstName, lastName, departmentNumber, salary, hoursWorked, grossSalary);  //Creating the new Info object
                    employeeInfoList.Add(anEmployee); //Adding the employee to the list using the Add() method
                    Console.WriteLine($"Employee's Name: {firstName} {lastName}\nGross salary: {grossSalary}\nDepartment Name: {departmentName[departmentNumber - 1]}");
                    departmentSalary[departmentNumber-1] = grossSalary + departmentSalary[departmentNumber-1];
                }
                else{
                    break;
                }
            }
            Console.WriteLine($"{departmentName[0]} Gross Salary: {departmentSalary[0]}\n{departmentName[1]} Gross Salary: {departmentSalary[1]}\n{departmentName[2]} Gross Salary: {departmentSalary[2]}\n{departmentName[3]} Gross Salary: {departmentSalary[3]}\n{departmentName[4]} Gross Salary: {departmentSalary[4]}\n{departmentName[5]} Gross Salary: {departmentSalary[5]}\n{departmentName[6]} Gross Salary: {departmentSalary[6]}");
        }
    }
    //Separate class used for making the List type
    class Info
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        public int departmentNumber {get; set;}
        public double salary {get; set;}
        public int hoursWorked {get; set;}
        public double grossSalary {get; set;}

        public Info(string firstName, string lastName, int departmentNumber, double salary, int hoursWorked, double grossSalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.departmentNumber = departmentNumber;
            this.salary = salary;
            this.hoursWorked = hoursWorked;
            this.grossSalary = grossSalary;
        }
    }
}
