using Microsoft.EntityFrameworkCore;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<ProblemChallenge> ProblemChallenges { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserField> UserFields { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public ApplicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}