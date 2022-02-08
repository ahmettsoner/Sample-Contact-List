using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Contact.Service.Data.Repositories;

namespace Contact.Service.API
{
    public class Persons : IPersons
    {
        private readonly IMapper mapper;
        private readonly IPersonRepository repository;

        public Persons(IMapper mapper, IPersonRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }
        
        public void AddNewPerson(DomainModels.Person Person){
            var PersonDAO = mapper.Map<Data.Models.Person>(Person);
            repository.AddNew(PersonDAO);
        }
        public async Task AddNewPersonAsync(DomainModels.Person Person){
            var PersonDAO = mapper.Map<Data.Models.Person>(Person);
            await repository.AddNewAsync(PersonDAO);
        }
        
        public void UpdatePerson(Guid Code, DomainModels.Person Person){
            var PersonDAO = repository.Get(Code);
            if(PersonDAO != null){
                mapper.Map(Person, PersonDAO);
                repository.Update(PersonDAO);
            }
        }
        
        public async Task UpdatePersonAsync(Guid Code, DomainModels.Person Person){
            var PersonDAO = await repository.GetAsync(Code);
            if(PersonDAO != null){
                mapper.Map(Person, PersonDAO);
                await repository.UpdateAsync(PersonDAO);
            }
        }
        
        public void DeletePerson(Guid Code){
            var PersonDAO = repository.Get(Code);
            if(PersonDAO != null){
                repository.Delete(PersonDAO);
            }
        }
        
        public async Task DeletePersonAsync(Guid Code){
            var PersonDAO = await repository.GetAsync(Code);
            if(PersonDAO != null){
                await repository.DeleteAsync(PersonDAO);
            }
        }
        
        public IEnumerable<DomainModels.Person> ListPersons(){
            IEnumerable<DomainModels.Person> result = default(IEnumerable<DomainModels.Person>);
            var PersonDAOs = repository.ListAll();
            
            result = mapper.Map<IEnumerable<Data.Models.Person>, IEnumerable<DomainModels.Person>>(PersonDAOs);

            return result;
        }
        
        public async Task<IEnumerable<DomainModels.Person>> ListPersonsAsync(){
            IEnumerable<DomainModels.Person> result = default(IEnumerable<DomainModels.Person>);
            var PersonDAOs = await repository.ListAllAsync();
            
            result = mapper.Map<IEnumerable<Data.Models.Person>, IEnumerable<DomainModels.Person>>(PersonDAOs);

            return result;
        }
        
        public async Task<DomainModels.Person> GetPersonAsync(Guid Code){
            DomainModels.Person result = default(DomainModels.Person);

            var PersonDAO = await repository.GetAsync(Code);
            if(PersonDAO != null){
                result = mapper.Map<DomainModels.Person>(PersonDAO);
            }

            return result;
        }
    }
}