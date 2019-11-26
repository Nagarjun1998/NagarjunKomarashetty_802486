using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Repositories;
using UserService.Models;
using Microsoft.AspNetCore.Cors;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]

    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;

        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<MentorDtl> Get()
        {
            return _repository.GetAll();
        }
        // POST: api/Mentor/Add
        [HttpPost]
        [Route("Add")]
        public IActionResult Post(MentorDtl item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Mentor/Update/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(string id, [FromBody] MentorDtl item)
        {
            _repository.Update(item);
        }

        [HttpPut("{id}")]
        [Route("Mentor_Block/{id}")]
        public string Put(string id)
        {
            _repository.Mentor_Block(id);
            return "blocked";

        }
        [Route("GetById/{id}")]
        public MentorDtl Get(string id)
        {
            return _repository.GetById(id);
        }

        // PUT: api/Mentor/ResetPassword/5
        [HttpPut("{id}")]
        [Route("ResetPassword/{id}")]
        public void PutPassword(string email,string newpass)
        {
            _repository.ResetPassword(email,newpass);

        }

        // DELETE: api/Mentor/Delete/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
