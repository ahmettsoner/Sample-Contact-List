using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Contact.Service.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ContactServiceDbContext context;

        public PersonRepository(ContactServiceDbContext context)
        {
            this.context = context;
        }

        public void AddNew(Models.Person entity){
            context.Add<Models.Person>(entity);
            context.SaveChanges();
        }

        public async Task AddNewAsync(Models.Person entity){
            await context.AddAsync<Models.Person>(entity);
            await context.SaveChangesAsync();
        }

        public void Update(Models.Person entity){
            context.SaveChanges();
        }

        public async Task UpdateAsync(Models.Person entity){
            await context.SaveChangesAsync();
        }

        public void Delete(Models.Person entity){
            context.Remove<Models.Person>(entity);
            context.SaveChanges();
        }

        public async Task DeleteAsync(Models.Person entity){
            context.Remove<Models.Person>(entity);
            await context.SaveChangesAsync();
        }

        public IEnumerable<Models.Person> ListAll()
        {
            IEnumerable<Models.Person> result = default(IEnumerable<Models.Person>);

            result = this.context.Set<Models.Person>().ToList();

            return result;
        }

        public async Task<IEnumerable<Models.Person>> ListAllAsync()
        {
            IEnumerable<Models.Person> result = default(IEnumerable<Models.Person>);

            result = await this.context.Set<Models.Person>().ToListAsync();

            return result;
        }

        public Models.Person Get(Guid ID)
        {
            Models.Person result = default(Models.Person);

            result = this.context.Set<Models.Person>().FirstOrDefault(o=>o.ID  == ID);

            return result;
        }

        public async Task<Models.Person> GetAsync(Guid ID)
        {
            Models.Person result = default(Models.Person);

            result = await this.context.Set<Models.Person>().FirstOrDefaultAsync(o=>o.ID  == ID);

            return result;
        }
    }
}