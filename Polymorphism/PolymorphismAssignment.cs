using System;
using employee;

// IQuittable Interface
namespace employee{
    interface IQuittable{
        void Quit();
    }
}

//From previous assignment
namespace employee{
    class Employee : Person, IQuittable{
        public int ID {get; set;}
        public void Quit(){
            Console.WriteLine("Employee quit.");
        }
    }
}

// From previous assignment
namespace employee{
    class Person{
        // Properties.
        // get; and set; allows the ability to get and set the variable of the FirstName and LastName
        public string FirstName {get; set;}
        public string LastName{get; set;}
        // Methods.
        public void SayName(){
            Console.WriteLine("Name: "+FirstName+" "+LastName);
        }
    }
}

namespace run{
    class Run{
        static void Main(){
            // Create a new object. IQuittable can be the type because Employee inherits from IQuittable
            IQuittable quitable = new Employee(){FirstName = "Bob", LastName = "Builder"};
            quitable.Quit();
            // It seems it does not have access to Person's methods however.
            Employee newEmployee = new Employee(){FirstName = "Bob", LastName = "Destroyer"};
            newEmployee.SayName();
            newEmployee.Quit();
            Console.ReadLine();
        }
    }
}