using Microsoft.AspNetCore.Mvc;
using Msv.Web.Models;
using Msv.Web.Service.IService;

namespace Msv.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new LoginRequestDto();

            return View(loginRequestDto);
        }
        public IActionResult Register() 
        {
            RegistrationRequestDto registrationRequestDto = new RegistrationRequestDto();
            return View(registrationRequestDto);
        }
        public IActionResult Logout() 
        {
            return View();
        }
    }
}
