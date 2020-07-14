using AutoMapper;
using DevProject.Business.Abstract;
using DevProject.DTO.DTOs.UserDtos;
using DevProject.Entities.Concrete;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevProject.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class UserController : Controller
    {
        private IAppUserService _appUser;
        private IDepartmentService _department;
        private UserManager<AppUser> _userManager;
        private IMapper _mapper;

        public UserController(IAppUserService appUser, IDepartmentService department, UserManager<AppUser> userManager, IMapper mapper)
        {
            _appUser = appUser;
            _department = department;
            _userManager = userManager;
            _mapper = mapper;
        }

        public IActionResult List()
        {
            TempData["Active"] = TempDataInfo.User;
            return View(_mapper.Map<List<UserListDto>>(_appUser.List()));
        }

        public IActionResult AddUser()
        {
            TempData["Active"] = TempDataInfo.User;
            ViewBag.Departments = new SelectList(_department.List(), "DepartmentId", "DepartmentName");
            return View(new AddUserDto());
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserDto model)
        {
            TempData["Active"] = TempDataInfo.User;
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Name = model.Name,
                    SurName = model.SurName,
                    Age = model.Age,
                    Salary = model.Salary,
                    DepartmentId = model.DepartmentId,
                    Picture = model.Picture
                };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var addRoleResult = await _userManager.AddToRoleAsync(user, "Member");
                    if (addRoleResult.Succeeded)
                    {
                        return RedirectToAction("List");
                    }

                    foreach (var item in addRoleResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View(model);
        }

        public IActionResult DeleteUser(int id)
        {
            TempData["Active"] = TempDataInfo.User;
            var user = _appUser.GetById(id);
            _appUser.Delete(user);
            return RedirectToAction("List");
        }

        public IActionResult UserDetails(int userId)
        {
            TempData["Active"] = TempDataInfo.User;
            var model = new UserDetailsDto()
            {
                User = _appUser.GetById(userId)
            };
            return View(model);
        }

    }
}
