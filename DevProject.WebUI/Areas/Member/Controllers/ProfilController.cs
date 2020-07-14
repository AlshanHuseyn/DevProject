using AutoMapper;
using DevProject.DTO.DTOs.UserDtos;
using DevProject.Entities.Concrete;
using DevProject.WebUI.BaseControllers;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DevProject.WebUI.Areas.Member.Controllers
{
    [Area(AreaInfo.Member)]
    [Authorize(Roles = RoleInfo.Member)]
    public class ProfilController : BaseIdentityController
    {
        private IMapper _mapper;

        public ProfilController(UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        {
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            TempData["Active"] = TempDataInfo.Profil;
            var appUser = await GirisEdenIstifadeci();
            return View(_mapper.Map<UserListDto>(appUser));
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserListDto model, IFormFile sekil)
        {
            TempData["Active"] = TempDataInfo.Profil;
            if (ModelState.IsValid)
            {
                var User =
                    _userManager.Users.FirstOrDefault(m => m.Id == model.Id);
                if (sekil != null)
                {
                    string uzanti = Path.GetExtension(sekil.FileName);
                    string sekilAd = Guid.NewGuid() + uzanti;
                    string path = Path.Combine(Directory.GetCurrentDirectory()
                        , "wwwroot/img/" + sekilAd);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await sekil.CopyToAsync(stream);
                    }

                    User.Picture = sekilAd;
                }

                User.Name = model.Name;
                User.SurName = model.SurName;
                User.Email = model.Email;

                var result = await _userManager.UpdateAsync(User);
                if (result.Succeeded)
                {
                    TempData["message"] = "Gunellendi";
                    return RedirectToAction("Index");
                }
                else
                {
                    XetaElaveEt(result.Errors);
                }
            }
            return View(model);
        }
    }
}
