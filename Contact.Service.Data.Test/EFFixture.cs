using System;
using Microsoft.EntityFrameworkCore;

namespace Contact.Service.Data.Test
{
    public class EFFixture : IDisposable
    {
        public ContactServiceDbContext Context {protected set; get;}
        public EFFixture()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            this.Context = new ContactServiceDbContext(optionsBuilder.Options);
            this.Context.Database.EnsureCreated();
        }

        public void Dispose()
        {
            this.Context.Database.EnsureDeleted();
        }
    }
}