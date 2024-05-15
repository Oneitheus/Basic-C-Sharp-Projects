using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Entity_Framework_Final_Assignment
{
    class StudentDbContext : DbContext
    {
        public StudentDbContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; }
    } 
}
