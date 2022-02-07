using Microsoft.EntityFrameworkCore;

namespace Contact.Service.Data
{
    public class ContactServiceDbContext : DbContext
    {
        DbSet<Models.Person> Persons{set;get;}
        DbSet<Models.Contact> Contacts{set;get;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Person>()
                .HasMany<Models.Contact>()
                .WithOne()
                .HasForeignKey(o=>o.ID);
        }
    }
}