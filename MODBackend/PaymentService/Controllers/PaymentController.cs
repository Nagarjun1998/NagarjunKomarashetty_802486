using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentService.Models;
using PaymentService.Repositories;

namespace PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]

    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _repository;

        public PaymentController(IPaymentRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Payment
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Payment> Get()
        {
            return _repository.GetAll();
        }


        // POST: api/Payment
        [HttpPost]
        [Route("Add")]

        public IActionResult Post([FromBody] Payment item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }


    }
}
