using BLL.Interfaces;
using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class UserService:IUserService
    {
        IUserRepository repository;

        public UserService(IUserRepository _repository)
        {
            repository = _repository;
        }
        public List<User> GetAllUsers()
        {
            return repository.GetUsers();
        }
        public void Add(User User)
        {
            repository.Add(User);
        }
        public void Remove(int id)
        {
            repository.Remove(id);
        }
        public void Update(User User)
        {
            repository.Update(User);
        }

        public User FindById(int id)
        {
            return repository.FindById(id);
        }

        public void Save(User user)
        {
            repository.Save(user);
        }

        public bool Exist(int id)
        {
            return repository.Exist(id);
        }
    }
}
