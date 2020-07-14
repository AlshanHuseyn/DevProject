using DevProject.Business.Abstract;
using DevProject.Entities.Concrete;
using DevProject.WebUI.Areas.Member.Models;
using DevProject.WebUI.BaseControllers;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevProject.WebUI.Areas.Member.Controllers
{
    [Area(AreaInfo.Member)]
    [Authorize(Roles = RoleInfo.Member)]
    public class HomeController : BaseIdentityController
    {
        private IReportService _reportService;
        private IJobService _jobService;
        private IBildirimService _bildirimService;

        public HomeController(IReportService reportService, UserManager<AppUser> userManager, IJobService jobService, IBildirimService bildirimService) : base(userManager)
        {
            _reportService = reportService;
            _jobService = jobService;
            _bildirimService = bildirimService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["Active"] = TempDataInfo.Home;
            var user = await GirisEdenIstifadeci();
            var model = new HomeViewModel()
            {
                OxunmamisBildirimSayi = _bildirimService.OxunmamusBildirimSayi(user.Id),
                ReportSayi = _reportService.ReportSayi(user.Id),
                TamamlananJobSayi = _jobService.JobSayiTamamlanan(user.Id),
                TamanlanmayanJobSayi = _jobService.TamamlanmayanJobSayi(user.Id)
            };
            return View(model);
        }
    }
}
