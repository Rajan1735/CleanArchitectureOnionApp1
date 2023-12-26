using Domain1;
using Microsoft.EntityFrameworkCore;

namespace OnionApp1.Service
{
    public interface IAppDbContext
    {
        DbSet<Student> Students { get; set; }
        Task<int> SaveChangesAsync();
    }
}
