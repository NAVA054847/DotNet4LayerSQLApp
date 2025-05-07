using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IStudentRepositories
    {
        List<Student> GetAll();
        Student GetById(int id);
        void AddStudents(Student student);
        void UpdateStudents(Student student,int id);
        void DeleteStudents(int id);


    }
}
