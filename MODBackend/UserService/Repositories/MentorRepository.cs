using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Context;
using UserService.Models;

namespace UserService.Repositories
{
    public class MentorRepository : IMentorRepository
    {
        private readonly UserContext _context;
        public MentorRepository(UserContext context)
        {
            _context = context;
        }
        public void Add(MentorDtl item)
        {
            try
            {
                _context.MentorDtls.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
         
        }
        public MentorDtl GetById(string id)
        {
            try
            {
                return _context.MentorDtls.Find(id);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<MentorDtl> GetAll()
        {
            return _context.MentorDtls.ToList();
        }

        public void Mentor_Block(string id)
        {
            var item = _context.MentorDtls.Find(id);
            if (item.Active == "True")
            {
                item.Active = "False";
            }
            else
            {
                item.Active = "True";
            }
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(string id)
        {
            var item = _context.MentorDtls.Find(id);
            _context.MentorDtls.Remove(item);
            _context.SaveChanges();
        }

        public void ResetPassword(string email,string newpass)
        {
            var obj = _context.MentorDtls.SingleOrDefault(i => i.Email==email);
            obj.Password = newpass;
            _context.SaveChanges();
        }

        public void Update(MentorDtl item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
