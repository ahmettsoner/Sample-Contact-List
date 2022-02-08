using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Contact.Service.Data.Repositories;

namespace Contact.Service.API
{
    public interface IContacts
    {
        void AddNewContact(DomainModels.Contact Contact);
        Task AddNewContactAsync(DomainModels.Contact Contact);
        
        void UpdateContact(Guid Code, DomainModels.Contact Contact);
        
        Task UpdateContactAsync(Guid Code, DomainModels.Contact Contact);
        
        void DeleteContact(Guid Code);
        
        Task DeleteContactAsync(Guid Code);
        
        public IEnumerable<DomainModels.Contact> ListContacts();
        
        Task<IEnumerable<DomainModels.Contact>> ListContactsAsync();
        
        public IEnumerable<DomainModels.Contact> ListPersonContacts(Guid personCode);
        
        Task<IEnumerable<DomainModels.Contact>> ListPersonContactsAsync(Guid personCode);
        
        Task<DomainModels.Contact> GetContactAsync(Guid Code);
    }
}