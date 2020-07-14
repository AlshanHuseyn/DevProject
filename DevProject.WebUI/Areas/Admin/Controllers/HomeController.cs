using AutoMapper;
using DevProject.Business.Abstract;
using DevProject.Entities.Concrete;
using DevProject.WebUI.Areas.Admin.Models.HomeModel;
using DevProject.WebUI.BaseControllers;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevProject.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class HomeController : BaseIdentityController
    {
        private IBildirimService _bildirimService;
        private IJobService _jobService;
        private IReportService _reportService;
        private IMapper _mapper;

        public HomeController
            (UserManager<AppUser> userManager, IBildirimService bildirimService, IJobService jobService, IReportService reportService, IMapper mapper) : base(userManager)
        {
            _bildirimService = bildirimService;
            _jobService = jobService;
            _reportService = reportService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            TempData["Active"] = TempDataInfo.Home;
            var user = await GirisEdenIstifadeci();
            var model = new AdminHomeViewModel()
            {
                BildirimSayi = _bildirimService.OxunmamusBildirimSayi(user.Id),
                TamamlanmisIssayi = _jobService.TamamlanmisIsSayi(),
                TeyinEdilmemisIsSayi = _jobService.TeyinEdilmemisJobSayi(),
                UmumiReportSayi = _reportService.ReportSayi()
            };
            return View(model);
        }
    }
}
