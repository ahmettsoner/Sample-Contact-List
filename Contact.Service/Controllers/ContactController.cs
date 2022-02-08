using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contact.Service.API;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContacts contactAPI;

        public ContactController(IContacts contactAPI)
        {
            this.contactAPI = contactAPI;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DomainModels.Contact>>> ListAllAsync(){
            var result = await this.contactAPI.ListContactsAsync();

            return Ok(result);
        }

        [HttpGet("person/{personCode}")]
        public async Task<ActionResult<IEnumerable<DomainModels.Contact>>> ListPersonContactsAsync(Guid personCode){
            
            var result = await this.contactAPI.ListPersonContactsAsync(personCode);

            return Ok(result);
        }

        [HttpGet("{code}")]
        public async Task<ActionResult<IEnumerable<DomainModels.Contact>>> GetAsync(Guid code){
            var result = await this.contactAPI.GetContactAsync(code);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<DomainModels.Contact>>> AddNewAsync(DomainModels.Contact Contact){
            
            await this.contactAPI.AddNewContactAsync(Contact);

            return CreatedAtAction(nameof(GetAsync), new { code = Contact.Code }, Contact);
        }

        [HttpPut("{code}")]
        public async Task<ActionResult<IEnumerable<DomainModels.Contact>>> UpdateAsync(Guid code, DomainModels.Contact Contact){
            
            await this.contactAPI.UpdateContactAsync(code, Contact);

            return Ok(Contact);
        }

        [HttpDelete("{code}")]
        public async Task<ActionResult<IEnumerable<DomainModels.Contact>>> DeleteAsync(Guid code){
            
            await this.contactAPI.DeleteContactAsync(code);

            return NoContent();
        }
    }
}