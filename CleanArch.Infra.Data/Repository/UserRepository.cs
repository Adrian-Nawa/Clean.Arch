using CleanArch.Domain.Interfices;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private TestDb _test;
        public UserRepository(TestDb testDb)
        {
            _test = testDb;
        }
        public void AddUser(User user)
        {
             _test.Add(user);
        }

        public bool IsExistEmail(string email)
        {
               return _test.Users.Any(u=>u.Email == email);
        }

        public bool IsExistUserName(string userName)
        {
             return _test.Users.Any(u => u.UserName == userName);
        }

        public void Save()
        {
            _test.SaveChanges();
        }
    }
}
