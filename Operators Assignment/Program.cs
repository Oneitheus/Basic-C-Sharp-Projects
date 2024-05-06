namespace Program{
    using System;
    using EmployeeSpace;
    class ProgramClass{
        public static void Main(){
            // Create employees
            Employee employee = new Employee(){Id = 10,FirstName = "Bob",LastName = "Mario"};
            Employee employee2 = new Employee(){Id = 10, FirstName = "Angela",LastName = "Uil"};
            Employee employee3 = new Employee(){Id = 11, FirstName = "John", LastName = "Doe"};
            //Comparison of employee and employee2
            Console.WriteLine(employee==employee2);
            //Comparison of employee 2 and employee3
            Console.WriteLine(employee2==employee3);
            Console.ReadLine();
        }
    }
}

namespace EmployeeSpace{
    using System;

    class Employee{
        public int Id{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}

        //Overload == to compare 2 employee objects together
        public static bool operator==(Employee currentEmployee,Employee targetEmployee){
            return currentEmployee.Id == targetEmployee.Id;
        }
        // Overload != Pair of ==
        public static bool operator!=(Employee currentEmployee,Employee targetEmployee){
            return currentEmployee.Id != targetEmployee.Id;
        }

        //So I can compile
        public override bool Equals(object o){
            return false;
        }
        //Mandatory so I can compile
        public override int GetHashCode(){
            return Id;
        }
    }
}