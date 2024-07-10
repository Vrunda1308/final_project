using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectC.Utilities
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                var student = new student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student saved to the database.");
                var students = context.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"{s.StudentId}: {s.FirstName} {s.LastName}, Enrolled: {s.EnrollmentDate}");
                }
            }
        }
    }
}