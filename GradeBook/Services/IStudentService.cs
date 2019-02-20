using GradeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Services
{
    public interface IStudentService
    {
        Task<Student> Authenticate(string username, string password);
    }

    public class StudentService : IStudentService
    {
        private readonly GradeBookContext _ctx;

        public StudentService(GradeBookContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Student> Authenticate(string username, string password)
        {
            var Student = await Task.Run(() => _ctx.Students.SingleOrDefault(x => x.Email == username && x.Password == password));

            // return null if user not found
            if (Student == null)
                return null;

            // authentication successful so return user details without password
            Student.Password = null;
            return Student;
        }

      
    }
}
