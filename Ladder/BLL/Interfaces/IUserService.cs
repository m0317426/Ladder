using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();

        User FindById(int id);

        void Add(User user);

        void Update(User user);

        void Remove(int userId);

        void Save(User user);

        bool Exist(int id);
    }
}
