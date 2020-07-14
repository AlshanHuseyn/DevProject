using AutoMapper;
using DevProject.Business.Abstract;
using DevProject.DTO.DTOs.UserDtos;
using DevProject.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DevProject.WebUI.ViewComponents
{
    public class Wrapper : ViewComponent
    {
        private UserManager<AppUser> _userManager;
        private IBildirimService _bildirimService;
        private IMapper _mapper;

        public Wrapper(UserManager<AppUser> userManager, IBildirimService bildirimService, IMapper mapper)
        {
            _userManager = userManager;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var identityUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var user = _mapper.Map<UserListDto>(identityUser);
            var bildirimler = _bildirimService.OxunmamisBildirimler(user.Id).Count;
            ViewBag.BildirimSayi = bildirimler;
            var roles = _userManager.GetRolesAsync(identityUser).Result;
            if (roles.Contains("Admin"))
            {
                return View(user);
            }

            return View("Member", user);
        }
    }
}
