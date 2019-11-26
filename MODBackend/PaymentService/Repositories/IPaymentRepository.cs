using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentService.Models;

namespace PaymentService.Repositories
{
    public interface IPaymentRepository
    {
        void Add(Payment item);
        IEnumerable<Payment> GetAll();
    }
}
