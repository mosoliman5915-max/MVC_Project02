
    using Microsoft.EntityFrameworkCore;
using MVC_Project02.Entities;
using System.Reflection;
namespace MVC_Project02.Context
{
    public class GymDbContext: DbContext

    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
        #region DbSets

        public DbSet <Trainer> Trainers { get; set; } = null!;
        public DbSet<Member> Members { get; set; } 

        public DbSet<MemberShip> memberShips { get; set; }

        public DbSet<Plan> plans { get; set; }

        public DbSet<Session> sessions { get; set; }


        #endregion

    }

}
