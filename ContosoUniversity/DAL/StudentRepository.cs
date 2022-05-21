using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.DAL
{
    public class StudentRepository : IStudentRepository
    {
        private SchoolContext context;

        public StudentRepository(SchoolContext context)
        {
            this.context = context;
        }
        public void DeleteStudent(int studentID)
        {
            context.Students.Remove(context.Students.Find(studentID));
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public Student GetStudentByID(int? studentId)
        {
            return context.Students.Find(studentId);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await context.Students.ToListAsync();
        }

        public void InsertStudent(Student student)
        {
            context.Students.Add(student);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            context.Entry(student).State = EntityState.Modified;
        }
    }
}
