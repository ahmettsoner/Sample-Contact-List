using System;
using Xunit;

namespace Contact.Service.Data.Test
{
    public class BasicTest1 : IClassFixture<EFFixture>
    {
        private readonly EFFixture fixture;

        public BasicTest1(EFFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            //Arrange
            var PersonDAO = new Models.Person (){
                Name = "Test",
                Age = 23
            };
            
            //Act
            this.fixture.Context.Persons.Add(PersonDAO);

            //Assert
            Assert.NotEqual(PersonDAO.ID, Guid.Empty);
        }
    }
}
