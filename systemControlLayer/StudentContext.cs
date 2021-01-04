using Microsoft.EntityFrameworkCore;

namespace systemControlLyar
{
    public class StudentContext : DbContext
    {
        public DbSet<StudentEntity> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("path=data.db");
    }
}