using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contact.Service.API;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersons personAPI;

        public PersonController(IPersons personAPI)
        {
            this.personAPI = personAPI;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DomainModels.Person>>> ListAllAsync(){
            var result = await this.personAPI.ListPersonsAsync();

            return Ok(result);
        }

        [HttpGet("{code}")]
        public async Task<ActionResult<IEnumerable<DomainModels.Person>>> GetAsync(Guid code){
            var result = await this.personAPI.GetPersonAsync(code);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<DomainModels.Person>>> AddNewAsync(DomainModels.Person person){
            
            await this.personAPI.AddNewPersonAsync(person);

            return CreatedAtAction(nameof(GetAsync), new { code = person.Code }, person);
        }

        [HttpPut("{code}")]
        public async Task<ActionResult<IEnumerable<DomainModels.Person>>> UpdateAsync(Guid code, DomainModels.Person person){
            
            await this.personAPI.UpdatePersonAsync(code, person);

            return Ok(person);
        }

        [HttpDelete("{code}")]
        public async Task<ActionResult<IEnumerable<DomainModels.Person>>> DeleteAsync(Guid code){
            
            await this.personAPI.DeletePersonAsync(code);

            return NoContent();
        }
    }
}