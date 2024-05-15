using System;
using System.Data.Entity.Validation;

namespace Entity_Framework_Final_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())
            {
                var student = new Student()
                {
                    name = "Gil",
                    grade = 55.55
                };

                context.Students.Add(student);
                try
                {
                    context.SaveChanges();
                } catch(DbEntityValidationException e)
                {
                    Console.WriteLine("Something went wrong.");
                }
                
            }
        }
    }
}
