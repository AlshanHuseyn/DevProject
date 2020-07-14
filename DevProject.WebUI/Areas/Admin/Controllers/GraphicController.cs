using DevProject.Business.Abstract;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DevProject.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class GraphicController : Controller
    {
        private IAppUserService _appUserService;

        public GraphicController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = TempDataInfo.Qrafik;
            return View();
        }

        public IActionResult EnCoxIsTamamlayan()
        {
            TempData["Active"] = TempDataInfo.Qrafik;
            var jsonString = JsonConvert.SerializeObject(_appUserService.EnCoxIsTamamlamisPersonallar());
            return Json(jsonString);
        }

        public IActionResult EnCoxIsdeCalisan()
        {
            TempData["Active"] = TempDataInfo.Qrafik;
            var jsonString = JsonConvert.SerializeObject(_appUserService.EnCoxIsdeCalisanPersonallar());
            return Json(jsonString);
        }
    }
}
