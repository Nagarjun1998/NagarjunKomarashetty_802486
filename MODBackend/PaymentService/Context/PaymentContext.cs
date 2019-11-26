using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaymentService.Models;

namespace PaymentService.Context
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) :base(options)
        {

        }
        public DbSet<Training> Trainings { get; set; }

        public DbSet<Userdtl> Userdtls { get; set; }
        public DbSet<MentorDtl> MentorDtls { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
