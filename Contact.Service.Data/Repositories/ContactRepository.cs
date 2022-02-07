using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Contact.Service.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactServiceDbContext context;

        public ContactRepository(ContactServiceDbContext context)
        {
            this.context = context;
        }

        public void AddNew(Models.Contact entity){
            context.Add<Models.Contact>(entity);
            context.SaveChanges();
        }

        public async Task AddNewAsync(Models.Contact entity){
            await context.AddAsync<Models.Contact>(entity);
            await context.SaveChangesAsync();
        }

        public void Update(Models.Contact entity){
            context.SaveChanges();
        }

        public async Task UpdateAsync(Models.Contact entity){
            await context.SaveChangesAsync();
        }

        public void Delete(Models.Contact entity){
            context.Remove<Models.Contact>(entity);
            context.SaveChanges();
        }

        public async Task DeleteAsync(Models.Contact entity){
            context.Remove<Models.Contact>(entity);
            await context.SaveChangesAsync();
        }

        public IEnumerable<Models.Contact> ListAll()
        {
            IEnumerable<Models.Contact> result = default(IEnumerable<Models.Contact>);

            result = this.context.Set<Models.Contact>().ToList();

            return result;
        }

        public async Task<IEnumerable<Models.Contact>> ListAllAsync()
        {
            IEnumerable<Models.Contact> result = default(IEnumerable<Models.Contact>);

            result = await this.context.Set<Models.Contact>().ToListAsync();

            return result;
        }

        public IEnumerable<Models.Contact> ListPersonContacts(Guid PersonID)
        {
            IEnumerable<Models.Contact> result = default(IEnumerable<Models.Contact>);

            result = this.context.Set<Models.Contact>().Where(o=>o.Person.ID == PersonID).ToList();

            return result;
        }

        public async Task<IEnumerable<Models.Contact>> ListPersonContactsAsync(Guid PersonID)
        {
            IEnumerable<Models.Contact> result = default(IEnumerable<Models.Contact>);

            result = await this.context.Set<Models.Contact>().Where(o=>o.Person.ID == PersonID).ToListAsync();

            return result;
        }

        public Models.Contact Get(Guid ID)
        {
            Models.Contact result = default(Models.Contact);

            result = this.context.Set<Models.Contact>().FirstOrDefault(o=>o.ID  == ID);

            return result;
        }

        public async Task<Models.Contact> GetAsync(Guid ID)
        {
            Models.Contact result = default(Models.Contact);

            result = await this.context.Set<Models.Contact>().FirstOrDefaultAsync(o=>o.ID  == ID);

            return result;
        }
    }
}