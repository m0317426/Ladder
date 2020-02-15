using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UserRepository:IUserRepository
    {
        DataContext context;

        public UserRepository(DataContext _context)
        {
            context = _context;
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }
       
        public User FindById(int id)
        {
            return context.Users.Where(u => u.UserId == id).Single();
        }

        public void Update(User User)
        {
            context.Users.Update(User);
            context.SaveChanges();
        }

        public void Add(User User)
        {
            context.Users.Add(User);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var User = context.Users.SingleOrDefault(u => u.UserId == id);
            context.Users.Remove(User);
            context.SaveChanges();
        }

        public void Save(User user)
        {
            context.SaveChanges();
        }

        public bool Exist(int id)
        {
            return context.Users.Any(e => e.UserId == id);                
        }
    }
}
