using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();

        User FindById(int id);

        void Update(User user);

        void Add(User user);

        void Remove(int id);

        void Save(User user);

        bool Exist(int id);
    }
}
