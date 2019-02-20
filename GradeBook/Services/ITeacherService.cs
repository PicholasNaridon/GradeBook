using GradeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Services
{
    public interface ITeacherService
    {
        Task<Teacher> Authenticate(string username, string password);
    }

    public class TeacherService : ITeacherService
    {
        private readonly GradeBookContext _ctx;

        public TeacherService(GradeBookContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Teacher> Authenticate(string username, string password)
        {
            var Teacher = await Task.Run(() => _ctx.Teachers.SingleOrDefault(x => x.Email == username && x.Password == password));

            // return null if user not found
            if (Teacher == null)
                return null;

            // authentication successful so return user details without password
            Teacher.Password = null;
            return Teacher;
        }

       
    }
}
