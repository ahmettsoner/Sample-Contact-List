using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Service.Data.Repositories
{
    public interface IPersonRepository
    {
        void AddNew(Models.Person entity);

        Task AddNewAsync(Models.Person entity);

        void Update(Models.Person entity);

        Task UpdateAsync(Models.Person entity);

        void Delete(Models.Person entity);

        Task DeleteAsync(Models.Person entity);

        IEnumerable<Models.Person> ListAll();

        Task<IEnumerable<Models.Person>> ListAllAsync();

        Models.Person Get(Guid ID);

        Task<Models.Person> GetAsync(Guid ID);
    }
}