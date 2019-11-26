using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateService.Context;
using AuthenticateService.Models;

namespace AuthenticateService.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }

        public MentorDtl MentorLogin(string mid,string password)
        {
            return  _context.MentorDtls.SingleOrDefault(data => data.MentorId == mid && data.Password == password);
            //if (obj != null)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }

        public Userdtl UserLogin(string uid, string password)
        {
            return  _context.Userdtls.SingleOrDefault(data => data.UserId == uid && data.Password == password);
            //if (obj != null)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }
    }
}
