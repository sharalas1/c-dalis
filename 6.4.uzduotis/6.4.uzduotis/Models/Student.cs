using System;

namespace _6._4.uzduotis.Models
{
    public class Student
    {
        public Student(string name, string surname, DateTime birthDay, string documentId)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthDay;
            DocumentId = documentId;
            Age = DateTime.Now.Year - birthDay.Year;
        }

        public string Name { get; } // ctrl ir . tada add parameter to Student()... ir automatiskai sugeneruoja
        
        public string Surname { get; }
        
        public DateTime BirthDay { get; }
        
        public string DocumentId { get; }
        public int Age { get; }

        public string GetInformation()
        {
            return $"{Name} {Surname} {BirthDay.ToString("yyyy-MM-dd")} {DocumentId} {Age}";
        }
    }
}
