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

    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        // GET: api/User/GetAll
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Userdtl> Get()
        {
            return _repository.GetAll();
        }
        // GET: api/User/SearchMentor
        [HttpGet]
        [Route("SearchMentor/{technology}/{timeslot}")]
        public IEnumerable<MentorDtl> Get(string technology , string timeslot)
        {
            return _repository.SearchMentor(technology,timeslot);
        }



        // POST: api/User/Add
        [HttpPost]
        [Route("Add")]
        public string Post(Userdtl item)
        {
            _repository.Add(item);
            return "Ok";
        }

        // PUT: api/User/Update/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public IActionResult Put(string id, [FromBody] Userdtl item)
        {
            _repository.Update(item);
            return Ok("Record Update");


        }

        [HttpPut("{id}")]
        [Route("User_Block/{id}")]
        public string Put(string id)
        {
            _repository.User_Block(id);
            return "blocked";

        }

        // PUT: api/User/ResetPassword/5
        [HttpPut("{id}")]
        [Route("ResetPassword/{email}/{newpass}")]
        public void PutPassword(string email,string newpass)
        {
            _repository.ResetPassword(email,newpass);

        }
        // DELETE: api/User/Delete/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            _repository.Delete(id);
            return Ok("Record Deleted");

        }
    }
}
