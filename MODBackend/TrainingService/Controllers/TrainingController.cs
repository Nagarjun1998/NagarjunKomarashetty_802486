using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingService.Models;
using TrainingService.Repositories;

namespace TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]

    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;

        public TrainingController(ITrainingRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Training/GetAll
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Training> Get()
        {
            return _repository.GetAll();
        }

        [Route("GetById/{id}")]
        public Training Get(string id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Training/Add
        [HttpPost]
        [Route("Add")]

        public IActionResult Post([FromBody] Training item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("Update")]
        public IActionResult Put( [FromBody] Training item)
        {
            _repository.Update(item);
            return Ok("Record Update");


        }

       
    }
}
