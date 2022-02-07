using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Service.Data.Repositories
{
    public interface IContactRepository
    {
        void AddNew(Models.Contact entity);

        Task AddNewAsync(Models.Contact entity);

        void Update(Models.Contact entity);

        Task UpdateAsync(Models.Contact entity);

        void Delete(Models.Contact entity);

        Task DeleteAsync(Models.Contact entity);

        IEnumerable<Models.Contact> ListAll();

        Task<IEnumerable<Models.Contact>> ListAllAsync();

        IEnumerable<Models.Contact> ListPersonContacts(Guid PersonID);

        Task<IEnumerable<Models.Contact>> ListPersonContactsAsync(Guid PersonID);

        Models.Contact Get(Guid ID);

        Task<Models.Contact> GetAsync(Guid ID);
    }
}