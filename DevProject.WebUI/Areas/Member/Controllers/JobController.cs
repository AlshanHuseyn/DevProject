using AutoMapper;
using DevProject.Business.Abstract;
using DevProject.DTO.DTOs.JobDtos;
using DevProject.DTO.DTOs.ReportDtos;
using DevProject.Entities.Concrete;
using DevProject.WebUI.BaseControllers;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevProject.WebUI.Areas.Member.Controllers
{
    [Area(AreaInfo.Member)]
    [Authorize(Roles = RoleInfo.Member)]
    public class JobController : BaseIdentityController
    {
        private IJobService _jobService;
        private UserManager<AppUser> _userManager;
        private IBildirimService _bildirimService;
        private IReportService _reportService;
        private IMapper _mapper;

        public JobController
            (IJobService jobService, UserManager<AppUser> userManager, IReportService reportService, IBildirimService bildirimService, IMapper mapper) : base(userManager)
        {
            _jobService = jobService;
            _userManager = userManager;
            _reportService = reportService;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            TempData["Active"] = TempDataInfo.Job;
            var user = await GirisEdenIstifadeci();
            return View(_mapper.Map<List<JobListDto>>(_jobService.butunCedveler(m => m.PersonalId == user.Id && !m.Status)));
        }

        public IActionResult AddReport(int id)
        {
            TempData["Active"] = TempDataInfo.Job;
            var job = _jobService.getirDepIdile(id);
            ReportAddDto model = new ReportAddDto();
            model.JobId = id;
            model.Job = job;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReport(ReportAddDto model)
        {
            TempData["Active"] = TempDataInfo.Job;
            if (ModelState.IsValid)
            {
                _reportService.Add(new Report()
                {
                    JobId = model.JobId,
                    Detay = model.Detay,
                    Basliq = model.Basliq
                });
                var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
                var aktivIstifadeci = await GirisEdenIstifadeci();
                foreach (var admin in adminUserList)
                {
                    _bildirimService.Add(new Bildirim()
                    {
                        Aciqlama = $"{aktivIstifadeci.Name} {aktivIstifadeci.SurName} yeni bir hesabat yazdi",
                        UserId = admin.Id
                    });
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult UpdateReport(int id)
        {
            TempData["Active"] = TempDataInfo.Job;
            var report = _reportService.GetJobWithId(id);
            ReportUpdateDto model = new ReportUpdateDto()
            {
                Basliq = report.Basliq,
                Detay = report.Detay,
                Id = report.Id,
                Job = report.Job,
                JobId = report.JobId
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateReport(ReportUpdateDto model)
        {
            TempData["Active"] = TempDataInfo.Job;
            if (ModelState.IsValid)
            {
                var report = _reportService.GetJobWithId(model.Id);

                report.Basliq = model.Basliq;
                report.Detay = model.Detay;

                _reportService.Update(report);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> TamamlaJob(int jobId)
        {
            TempData["Active"] = TempDataInfo.Job;
            var job = _jobService.GetById(jobId);
            job.Status = true;
            _jobService.Update(job);
            var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
            var aktivIstifadeci = await GirisEdenIstifadeci();
            foreach (var admin in adminUserList)
            {
                _bildirimService.Add(new Bildirim()
                {
                    Aciqlama = $"{aktivIstifadeci.Name} {aktivIstifadeci.SurName} verilmis isi tamamladi",
                    UserId = admin.Id
                });
            }
            return Json(null);
        }

        public async Task<IActionResult> TamamlananIsler(int aktivSehife = 1)
        {
            TempData["Active"] = TempDataInfo.JobT;
            var user = await GirisEdenIstifadeci();
            int umumiSehife;
            var isler = _mapper.Map<List<JobListDto>>(
                _jobService.butunCedvelerTamamlanmayan(out umumiSehife, user.Id, aktivSehife));
            ViewBag.AktivSehife = aktivSehife;
            ViewBag.UmumiSehife = umumiSehife;
            return View(isler);
        }
    }
}
