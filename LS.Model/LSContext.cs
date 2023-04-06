using Microsoft.EntityFrameworkCore;

namespace LS.Model
{
    public class LSContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DbSet<Department> Department { get; set; }

        public DbSet<Faculty> Faculty { get; set; }

        public DbSet<Subject> Subject { get; set; }

        public DbSet<InstructorSchedule> InstructorSchedule { get; set; }

        public DbSet<SubjectSchedule> SubjectSchedule { get; set; }

        public DbSet<Schedule> Schedule { get; set; }

        public DbSet<RoomSubjectSchedule> RoomSubjectSchedule { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<Location> Location { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SubjectLoadingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>()
                .HasMany(j => j.InstructorSchedules)
                .WithOne(j => j.Instructor)

                .HasForeignKey(j => j.FacultyID)

                .IsRequired()
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<Faculty>()
                .HasMany(j => j.AdminApprovedSchedules)
                .WithOne(j => j.AdminFaculty)
                .HasForeignKey(j => j.AdminFacultyID)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientNoAction);

        }
    }
}