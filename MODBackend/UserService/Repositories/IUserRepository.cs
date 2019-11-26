using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.Repositories
{
    public interface IUserRepository
    {
        void Add(Userdtl item);
        IEnumerable<MentorDtl> SearchMentor(string technology,string timeslot);
        void Update(Userdtl item);
        IEnumerable<Userdtl> GetAll();
        void User_Block(string id);
        void ResetPassword(string email,string newpass);
        void Delete(string id);
    }
}
