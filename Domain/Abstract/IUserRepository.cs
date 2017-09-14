using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitis;

namespace Domain.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        bool AddUser(User user);
        void SaveUser(User user);
        User DeleteUser(int IdUser);
    }
}
