using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingService.Models;
namespace TrainingService.Context
{
    public class TrainingContext : DbContext
    {
        public TrainingContext(DbContextOptions<TrainingContext> options):base(options)
        {

        }
        public DbSet<Training> Trainings { get; set; }

        public DbSet<Userdtl> Userdtls { get; set; }
        public DbSet<MentorDtl> MentorDtls { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
