using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Contact.Service.Data.Repositories;

namespace Contact.Service.API
{
    public class Contacts : IContacts
    {
        private readonly IMapper mapper;
        private readonly IContactRepository repository;

        public Contacts(IMapper mapper, IContactRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }
        
        public void AddNewContact(DomainModels.Contact Contact){
            var ContactDAO = mapper.Map<Data.Models.Contact>(Contact);
            repository.AddNew(ContactDAO);
        }
        public async Task AddNewContactAsync(DomainModels.Contact Contact){
            var ContactDAO = mapper.Map<Data.Models.Contact>(Contact);
            await repository.AddNewAsync(ContactDAO);
        }
        
        public void UpdateContact(Guid Code, DomainModels.Contact Contact){
            var ContactDAO = repository.Get(Code);
            if(ContactDAO != null){
                mapper.Map(Contact, ContactDAO);
                repository.Update(ContactDAO);
            }
        }
        
        public async Task UpdateContactAsync(Guid Code, DomainModels.Contact Contact){
            var ContactDAO = await repository.GetAsync(Code);
            if(ContactDAO != null){
                mapper.Map(Contact, ContactDAO);
                await repository.UpdateAsync(ContactDAO);
            }
        }
        
        public void DeleteContact(Guid Code){
            var ContactDAO = repository.Get(Code);
            if(ContactDAO != null){
                repository.Delete(ContactDAO);
            }
        }
        
        public async Task DeleteContactAsync(Guid Code){
            var ContactDAO = await repository.GetAsync(Code);
            if(ContactDAO != null){
                await repository.DeleteAsync(ContactDAO);
            }
        }
        
        public IEnumerable<DomainModels.Contact> ListContacts(){
            IEnumerable<DomainModels.Contact> result = default(IEnumerable<DomainModels.Contact>);
            var ContactDAOs = repository.ListAll();
            
            result = mapper.Map<IEnumerable<Data.Models.Contact>, IEnumerable<DomainModels.Contact>>(ContactDAOs);

            return result;
        }
        
        public async Task<IEnumerable<DomainModels.Contact>> ListContactsAsync(){
            IEnumerable<DomainModels.Contact> result = default(IEnumerable<DomainModels.Contact>);
            var ContactDAOs = await repository.ListAllAsync();
            
            result = mapper.Map<IEnumerable<Data.Models.Contact>, IEnumerable<DomainModels.Contact>>(ContactDAOs);

            return result;
        }
        
        public IEnumerable<DomainModels.Contact> ListPersonContacts(Guid personCode){
            IEnumerable<DomainModels.Contact> result = default(IEnumerable<DomainModels.Contact>);
            var ContactDAOs = repository.ListPersonContacts(personCode);
            
            result = mapper.Map<IEnumerable<Data.Models.Contact>, IEnumerable<DomainModels.Contact>>(ContactDAOs);

            return result;
        }
        
        public async Task<IEnumerable<DomainModels.Contact>> ListPersonContactsAsync(Guid personCode){
            IEnumerable<DomainModels.Contact> result = default(IEnumerable<DomainModels.Contact>);
            var ContactDAOs = await repository.ListPersonContactsAsync(personCode);
            
            result = mapper.Map<IEnumerable<Data.Models.Contact>, IEnumerable<DomainModels.Contact>>(ContactDAOs);

            return result;
        }
        
        public async Task<DomainModels.Contact> GetContactAsync(Guid Code){
            DomainModels.Contact result = default(DomainModels.Contact);

            var ContactDAO = await repository.GetAsync(Code);
            if(ContactDAO != null){
                result = mapper.Map<DomainModels.Contact>(ContactDAO);
            }

            return result;
        }
    }
}