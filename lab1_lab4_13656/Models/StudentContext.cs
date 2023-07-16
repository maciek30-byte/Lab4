using ApiStudent.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiStudent.Models
{
    public class StudentContext : DbContext
    {
        public class StudentDbContext : IdentityDbContext<UserEntity,UserRole, int>
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
