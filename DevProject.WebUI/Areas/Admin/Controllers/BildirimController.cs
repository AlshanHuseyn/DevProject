using AutoMapper;
using DevProject.Business.Abstract;
using DevProject.DTO.DTOs.BildirimDtos;
using DevProject.Entities.Concrete;
using DevProject.WebUI.BaseControllers;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevProject.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class BildirimController : BaseIdentityController
    {
        private IBildirimService _bildirimService;
        private IMapper _mapper;

        public BildirimController(IBildirimService bildirimService, UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        {
            _bildirimService = bildirimService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            TempData["Active"] = TempDataInfo.Bildirim;
            var user = await GirisEdenIstifadeci();
            return View(_mapper.Map<List<BildirimListDto>>(_bildirimService.OxunmamisBildirimler(user.Id)));
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            TempData["Active"] = TempDataInfo.Bildirim;
            var bildirim = _bildirimService.Bildirim(id);
            bildirim.Status = true;
            _bildirimService.Update(bildirim);
            return RedirectToAction("Index");
        }
    }
}
