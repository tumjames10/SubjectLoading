using Microsoft.EntityFrameworkCore;

namespace LS.Model
{
    public class LSContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DbSet<Department> Department { get; set; }

        public DbSet<Faculty> Faculty { get; set; }

        public DbSet<Subject> Subject { get; set; }

        public DbSet<InstructorSchedule> InstructorSchedule { get; set; }

        public DbSet<RoomSubjectSchedule> RoomSubjectSchedule { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Semester> Semester { get; set; }

        public DbSet<Request> Request { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SubjectLoadingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}