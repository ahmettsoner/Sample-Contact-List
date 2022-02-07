using System;
using System.Collections.Generic;
using System.Linq;
using Contact.Service.Data.Repositories;
using Xunit;

namespace Contact.Service.Data.Test
{
    public class BasicRepositoryTest1 : IClassFixture<EFFixture>
    {
        private readonly EFFixture fixture;

        public BasicRepositoryTest1(EFFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            //Arrange
            PersonRepository personRepository = new PersonRepository(this.fixture.Context);
            var PersonDAO = new Models.Person (){
                Name = "Test",
                Age = 23
            };
            
            
   
            //Act
            personRepository.AddNew(PersonDAO);

            //Assert
            Assert.NotEqual(PersonDAO.ID, Guid.Empty);
        }
    }
}
