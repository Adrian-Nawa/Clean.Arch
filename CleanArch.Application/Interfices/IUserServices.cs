using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfices
{
    public interface IUserServices
    {
        CheckUser checkUser(string username , string email);
        int RegisterUser(User user);
    }
}
