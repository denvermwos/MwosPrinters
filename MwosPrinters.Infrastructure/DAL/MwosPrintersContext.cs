using MwosPrinters.Core;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MwosPrinters.Infrastructure.DAL
{
    public class MwosPrintersContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<NashuaBranch> NashuaBranches { get; set; }
        public DbSet<NashuaContact> NashuaContacts { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
