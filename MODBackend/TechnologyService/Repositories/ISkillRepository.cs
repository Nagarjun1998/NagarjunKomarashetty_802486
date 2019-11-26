using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnologyService.Models;
namespace TechnologyService.Repositories
{
    public interface ISkillRepository
    {
        void Add(Skill item);
        IEnumerable<Skill> GetSkills();
        Skill GetById(string id);
        Skill GetName(string name);

        void Update(Skill item);
        void Delete(string id);

    }
}
