using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Contact.Service.Data.Repositories;

namespace Contact.Service.API
{
    public interface IPersons
    {
        void AddNewPerson(DomainModels.Person Person);
        Task AddNewPersonAsync(DomainModels.Person Person);
        
        void UpdatePerson(Guid Code, DomainModels.Person Person);
        
        Task UpdatePersonAsync(Guid Code, DomainModels.Person Person);
        
        void DeletePerson(Guid Code);
        
        Task DeletePersonAsync(Guid Code);
        
        public IEnumerable<DomainModels.Person> ListPersons();
        
        Task<IEnumerable<DomainModels.Person>> ListPersonsAsync();
        
        Task<DomainModels.Person> GetPersonAsync(Guid Code);
    }
}