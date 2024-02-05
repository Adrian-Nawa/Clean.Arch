using CleanArch.Application.Interfices;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfices;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class UserServices : IUserServices
    {
        IUserRepository _userrepository;
        public UserServices(IUserRepository userrepository)
        {
            _userrepository = userrepository;
        }

        public CheckUser checkUser(string username, string email)
        {
            bool userNameValid = _userrepository.IsExistUserName(username);
            bool emailValid = _userrepository.IsExistEmail(email.Trim().ToLower());
            if (userNameValid && emailValid)
                return ViewModels.CheckUser.UserNameAndEmailNotValid;
            else if (emailValid)
                return CheckUser.EmailAdressNotValid;
            else if(userNameValid)
                return CheckUser.UserNameNotValid;
            return CheckUser.OK;
        }

        public int RegisterUser(User user)
        {
            _userrepository.AddUser(user);
            _userrepository.Save();
            return user.UserId;
        }
    }
}
