using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingService.Context;
using TrainingService.Models;

namespace TrainingService.Repositories
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }
        public void Add(Training item)
        {
            _context.Trainings.Add(item);
            _context.SaveChanges();
        }
        public Training GetById(string id)
        {
            return _context.Trainings.Find(id);
        }
        public IEnumerable<Training> GetAll()
        {
            return _context.Trainings.ToList();
        }

        public void Update(Training item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
