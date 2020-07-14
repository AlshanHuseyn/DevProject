using AutoMapper;
using DevProject.Business.Abstract;
using DevProject.DTO.DTOs.SignDtos;
using DevProject.Entities.Concrete;
using DevProject.WebUI.BaseControllers;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace DevProject.WebUI.Controllers
{
    public class HomeController : BaseIdentityController
    {
        private readonly ILogger<HomeController> _logger;
        private SignInManager<AppUser> _uSignInManager;
        private IMapper _mapper;
        private ICustomLogger _customLogger;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> uSignInManager, IMapper mapper, ICustomLogger customLogger) : base(userManager)
        {
            _logger = logger;
            _uSignInManager = uSignInManager;
            _mapper = mapper;
            _customLogger = customLogger;
        }

        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInDto model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                if (user != null)
                {
                    var identityResult = await _uSignInManager.PasswordSignInAsync
                        (model.Username, model.Password, model.RememberMe, false);
                    if (identityResult.Succeeded)
                    {
                        var rollar = await _userManager.GetRolesAsync(user);
                        if (rollar.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { area = "Member" });
                        }
                    }
                }
                ModelState.AddModelError("", "İstifadəçi Adı və ya Şifrə xətalı");
            }
            return View("SignIn", model);
        }

        public IActionResult SignUp()

        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = model.Username,
                    Email = model.Email,
                    Name = model.Name,
                    SurName = model.Surname,
                    Age = model.Age
                };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var addRoleResult = await _userManager.AddToRoleAsync(user, "Member");
                    if (addRoleResult.Succeeded)
                    {
                        return RedirectToAction("SignIn");
                    }
                    XetaElaveEt(addRoleResult.Errors);
                }

                XetaElaveEt(result.Errors);
            }

            return View(model);
        }

        public async Task<IActionResult> SignOut()
        {
            await _uSignInManager.SignOutAsync();
            return RedirectToAction("SignIn");
        }

        public IActionResult StatusCode(int? code)
        {
            if (code == 404)
            {
                ViewBag.Code = code;
                ViewBag.Message = "Sehife tapilmadi";
            }
            return View();
        }

        public IActionResult Erorr()
        {
            var exceptionHandler =
                HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            _customLogger.LogError
                ($"Xetanin yarandigi yer :{exceptionHandler.Path}\n" +
                 $"Xetanin messaji :{exceptionHandler.Error.Message}\n" +
                 $"Stack Trace :{exceptionHandler.Error.StackTrace}");
            ViewBag.Path = exceptionHandler.Path;
            ViewBag.Message = exceptionHandler.Error.Message;
            return View();
        }

        public void Xeta()
        {
            throw new Exception("Bu bir Xeta");
        }
    }
}
