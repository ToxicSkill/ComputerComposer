using System.Data.Entity;
using ComputerComposerNsp.Models.Entities;

namespace ComputerComposerNsp.Models
{
    /// <summary>
    /// Connection to SQL class
    /// </summary>
    public class DataBaseContext : DbContext
    {
        public DataBaseContext():base(nameOrConnectionString:"ConnectionString")
        {

        }

        public DbSet<Box> Boxes { get; set; }

        public DbSet<Computer> Computers { get; set; }

        public DbSet<Graphic> Graphics { get; set; }

        public DbSet<PowerUnit> PowerUnits { get; set; }

        public DbSet<Processor> Processors { get; set; }

        public DbSet<Ram> Rams { get; set; }

        public DbSet<OSystem> OSystems { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
