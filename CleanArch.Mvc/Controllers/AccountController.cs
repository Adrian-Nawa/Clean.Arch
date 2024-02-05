using CleanArch.Application.Interfices;
using CleanArch.Application.Security;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    public class AccountController : Controller
    {
        IUserServices _userService;
        public AccountController(IUserServices userServices)
        {
            _userService=userServices;
        }
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
                return View(register);
            CheckUser checkUser = _userService.checkUser(register.UserName, register.Email);
            if (checkUser != CheckUser.OK)
            {
                ViewBag.Check = checkUser;
                return View(register);
            }
            User users = new User()
            {
                Email=register.Email.Trim().ToLower(),
                Password=PasswordInCode.EncodePasswordMd5(register.Password),
                UserName=register.UserName,
            };
            _userService.RegisterUser(users);
            return View("SuccessRegister",register);
        }
    }
}
