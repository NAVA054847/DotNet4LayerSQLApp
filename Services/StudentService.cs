using Core.Repositories;
using Core.Services;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StudentService : IStudentService
    {
        IStudentRepositories _repositories;

        public StudentService(IStudentRepositories repositories)
        {
            _repositories = repositories;
        }

        public void AddStudents(Student student)
        {
            _repositories.AddStudents(student);
        }

        public void DeleteStudents(int id)
        {
            _repositories.DeleteStudents(id);
        }

        public List<Student> GetAll()
        {
           return _repositories.GetAll();
        }

        public Student GetById(int id)
        {
           return _repositories.GetById(id);
        }

        public void UpdateStudents(Student student, int id)
        {
            _repositories.UpdateStudents(student, id);
        }
    }
}
