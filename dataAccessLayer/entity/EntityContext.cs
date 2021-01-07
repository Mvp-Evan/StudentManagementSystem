using Microsoft.EntityFrameworkCore;

namespace dataAccessLayer.entity
{
    public class EntityContext : DbContext
    {
        public DbSet<StudentEntity> students { get; set; }
        
        public DbSet<TeacherEntity> teachers { get; set; }
        
        public DbSet<ClassEntity> classes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("data source=data.db");
        }
    }
}