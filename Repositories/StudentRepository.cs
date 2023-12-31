using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { StudentID = 1, Name = "Gamaliel Lexi Tulus", Email = "gmaliellexi28@gmail.com", BirthDate = new DateOnly(2003, 12, 28)},
            new Student { StudentID = 2, Name = "Alfariel Tulus", Email = "alfarieltls@gmail.com", BirthDate = new DateOnly(2001, 6, 6)},
            new Student { StudentID = 3, Name = "Varel Krisna Wiwowo", Email = "varelcomel@gmail.com", BirthDate = new DateOnly(2003, 1, 30)},
            new Student { StudentID = 4, Name = "Christian Denny Christanto", Email = "denny@gmail.com", BirthDate = new DateOnly(2003, 05, 28)},
        };

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.First(s => s.StudentID == id);
        }
    }
}