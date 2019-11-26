using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentService.Context;
using PaymentService.Models;

namespace PaymentService.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }
        public void Add(Payment item)
        {
            _context.Payments.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Payment> GetAll()
        {
            return _context.Payments.ToList();
        }
    }
}
