using GradeBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GradeBook.Services
{
    public class StudentRepo : IGenericRepository<Student, int>
    {
        private readonly GradeBookContext _ctx;

        public StudentRepo(GradeBookContext ctx)
        {
            _ctx = ctx;
        }

        public void Insert(Student entity)
        {
            _ctx.Students.Add(entity);
        }

        public void Delete(int id)
        {
            Student obj = _ctx.Students.Where(x => x.Id == id).SingleOrDefault();
            _ctx.Students.Remove(obj);
        }

        public void Update(Student entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<Student> FindBy(int id)
        {
            return _ctx.Students.Where(x => x.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _ctx.Students.ToList();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
    }
}
