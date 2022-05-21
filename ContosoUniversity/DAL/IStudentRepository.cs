using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.DAL
{
    public interface IStudentRepository : IDisposable
    {
        Task<IEnumerable<Student>> GetStudents();
        Student GetStudentByID(int? studentId);
        void InsertStudent(Student student);
        void DeleteStudent(int studentID);
        void UpdateStudent(Student student);
        void Save();
    }
}
