using ArmyBuilder.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ArmyBuilder.DAL
{
    public class UnitsContext : DbContext
    {
        public UnitsContext() : base("DBConnection") { }

        public DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}