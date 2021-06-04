using DemoApp.DAL.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DemoApp.DAL
{
    public class DemoAppContext : DbContext
    {
        public DbSet<CustomerType> CustomerTypes { get; set; }

        public DbSet<ActivityType> ActivityTypes { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Activity> Activities { get; set; }

        public DemoAppContext() : base("demoAppConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}