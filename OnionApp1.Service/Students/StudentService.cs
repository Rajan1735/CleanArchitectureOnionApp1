using Domain1;
using Domain1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp1.Service.Students
{
    public class StudentService : IStudentService
    {
        private readonly IAppDbContext _context;
        public StudentService(IAppDbContext context)
        {
            _context = context;
        }
        public async Task<int> Save(StudentDto command)
        {
            var student = new Student();
            student.Name = command.Name;
            student.Standard = command.Standard;
            student.Rank = command.Rank;

            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student.Id;
        }
    }
}
