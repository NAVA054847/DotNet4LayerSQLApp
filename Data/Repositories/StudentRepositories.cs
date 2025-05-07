using Core.Repositories;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class StudentRepositories : IStudentRepositories
    {

        DataContext _context;

        public StudentRepositories(DataContext context)
        {
           _context = context;
        }

        public void AddStudents(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void DeleteStudents(int id)
        {
            var list = GetById(id);
            if(list != null)
            {
                _context.Students.Remove(list);
                    _context.SaveChanges();

            }

        }

        public List<Student> GetAll()
        {
           return _context.Students.ToList();
            
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.StudentId == id);
        }

        public void UpdateStudents(Student student,int id )
        {
            //_context.Students.Update(student);
            Student s = _context.Students.FirstOrDefault(x => x.StudentId == id);
            s=student;

            _context.SaveChanges();
        }
    }
}
