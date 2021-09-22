using _6._4.uzduotis.Models;
using System.Collections.Generic;
using System;
namespace _6._4.uzduotis.Services
{
    public class StudentService
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            students.Add(
                new Student(
                    "Jonas", 
                    "Jonaitis", 
                    new DateTime(2000, 01, 01), 
                    "abb123"
                    )
                );
            students.Add(
                new Student(
                    "Onute",
                    "Pakalnute",
                    new DateTime(2001, 01, 01),
                    "abb124"
                    )
                );
            students.Add(
                new Student(
                    "Petras",
                    "Petraitis",
                    new DateTime(1999, 05, 06),
                    "abb155"
                    )
                );
            students.Add(
                new Student(
                    "Barbora",
                    "Bora",
                    new DateTime(2000, 11, 01),
                    "abb177"
                    )
                );
            students.Add(
                new Student(
                    "Greta",
                    "Geriete",
                    new DateTime(2004, 12, 05),
                    "abb189"
                    )
                );



            return students;
        }
    }
}
