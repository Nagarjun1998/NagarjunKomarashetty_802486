using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.Repositories
{
    public interface IMentorRepository
    {
        void Add(MentorDtl item);
        void Update(MentorDtl item);
        IEnumerable<MentorDtl> GetAll();
        void Mentor_Block(string id);
        MentorDtl GetById(string id);

        void ResetPassword(string email , string newpass);
        void Delete(string id);
    }
}
