using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateService.Models;

namespace AuthenticateService.Repositories
{
    public interface ILoginRepository
    {
        Userdtl UserLogin(string id, string password);
        MentorDtl MentorLogin(string id, string password);
    }
}
