using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Context;
using UserService.Models;

namespace UserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void Add(Userdtl item)
        {
            try
            {
                _context.Userdtls.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public IEnumerable<Userdtl> GetAll()
        {
            try
            {
                return _context.Userdtls.ToList();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void Delete(string id)
        {
            try
            {
                var item = _context.Userdtls.Find(id);
                _context.Userdtls.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void ResetPassword(string email,string newpass)
        {
            try
            {
                var obj = _context.Userdtls.SingleOrDefault(i => i.Email == email);
                obj.Password = newpass;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        public void User_Block(string id)
        {
            try
            {
                var item = _context.Userdtls.Find(id);
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
            catch (Exception)
            {

                throw;
            }
            
        }

        public IEnumerable<MentorDtl> SearchMentor(string technology , string timeslot)
        {
            try
            {
                var obj = _context.MentorDtls.Where(s => s.Technologies == technology || s.TimeSlot == timeslot).ToList();
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        public void Update(Userdtl item)
        {
            try
            {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
