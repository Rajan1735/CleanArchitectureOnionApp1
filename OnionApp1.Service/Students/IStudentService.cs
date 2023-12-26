using Domain1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp1.Service.Students
{
    public interface IStudentService
    {
        Task<int> Save(StudentDto model);
    }
}
