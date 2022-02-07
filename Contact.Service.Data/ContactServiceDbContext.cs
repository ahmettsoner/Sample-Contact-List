using Microsoft.EntityFrameworkCore;

namespace Contact.Service.Data
{
    public class ContactServiceDbContext : DbContext
    {
        public DbSet<Models.Person> Persons{set;get;}
        public DbSet<Models.Contact> Contacts{set;get;}

        private ContactServiceDbContext()
        {
            
        }
        public ContactServiceDbContext(DbContextOptions options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Person>()
                .HasMany<Models.Contact>()
                .WithOne()
                .HasForeignKey(o=>o.ID);
        }
    }
}