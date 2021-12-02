using Microsoft.AspNetCore.Mvc;
using Vuture.Models.Dtos;

namespace Vuture.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public ContactController()
        {
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetContactById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ReadContactDto> CreateContact([FromBody] CreateContactDto createContactDto)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<ReadContactDto> UpdateContactById(int id, UpdateContactDto updateContactDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteContactById(int id)
        {
            throw new NotImplementedException();
        }
    }
}