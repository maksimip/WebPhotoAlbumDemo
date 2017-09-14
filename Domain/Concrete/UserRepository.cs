using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstract;
using Domain.Entitis;

namespace Domain.Concrete
{
    public class UserRepository : IUserRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<User> Users { get { return context.Users; } }

        private bool UserIsExist(User userParam)
        {
            var users = context.Users.Select(u => u).Where(u => u.Email == userParam.Email);
            if (users.Count() != 0)
            {
                return true;
            }
            else
                return false;
            
        }

        public bool AddUser(User user)
        {
            if (!UserIsExist(user))
            {
                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public User DeleteUser(int IdUser)
        {
            throw new NotImplementedException();
        }

        public void SaveUser(User user)
        {
            User dbEntry = context.Users.Find(user.IdUser);

            if (dbEntry != null)
            {
                dbEntry.FirstName = user.FirstName;
                dbEntry.LastName = user.LastName;
                dbEntry.Email = user.Email;
                dbEntry.Pass = user.Pass;
                dbEntry.Country = user.Country;
                dbEntry.Age = user.Age;
            }

            context.SaveChanges();

        }
    }
}
