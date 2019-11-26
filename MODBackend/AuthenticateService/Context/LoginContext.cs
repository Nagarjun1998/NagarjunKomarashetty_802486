using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateService.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticateService.Context
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options):base(options)
        {

        }
        public DbSet<Training> Trainings { get; set; }

        public DbSet<Userdtl> Userdtls { get; set; }
        public DbSet<MentorDtl> MentorDtls { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
