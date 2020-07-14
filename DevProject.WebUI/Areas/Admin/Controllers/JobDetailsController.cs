using AutoMapper;
using DevProject.Business.Abstract;
using DevProject.DTO.DTOs.JobDtos;
using DevProject.DTO.DTOs.UserDtos;
using DevProject.Entities.Concrete;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevProject.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class JobDetailsController : Controller
    {
        private readonly IJobService _jobService;
        private readonly IAppUserService _appUser;
        private readonly UserManager<AppUser> _userManager;
        private readonly IBildirimService _bildirimService;
        private IMapper _mapper;

        public JobDetailsController(IAppUserService appUser, IJobService jobService, UserManager<AppUser> userManager, IBildirimService bildirimService, IMapper mapper)
        {
            _appUser = appUser;
            _jobService = jobService;
            _userManager = userManager;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult JobDetails(int id, string s, int sehife = 1)
        {
            TempData["Active"] = TempDataInfo.Job;
            ViewBag.aktivSehife = sehife;
            int umumiSehife;
            ViewBag.Axtarilan = s;

            var personallar = _mapper.Map<List<UserListDto>>(_appUser.IsUzreIsciSayi
                (out umumiSehife, id, s, sehife));
            ViewBag.UmumiSehife = umumiSehife;

            ViewBag.Personallar = personallar;

            return View(_mapper.Map<JobListDto>(_jobService.GetById(id)));
        }

        [HttpPost]
        public IActionResult JobDetails(PersonalGorevlendirDto model)
        {
            TempData["Active"] = TempDataInfo.Job;
            var guncellenecekJob = _jobService.GetById(model.JobId);
            guncellenecekJob.PersonalId = model.UserId;
            _jobService.Update(guncellenecekJob);

            _bildirimService.Add(new Bildirim()
            {
                UserId = model.UserId,
                Aciqlama = $"{guncellenecekJob.Name} adli is ucun gorevlendirildiniz!"
            });
            return RedirectToAction("List", "Admin");
        }

        public IActionResult GorevlendirPersonel(int userId)
        {
            TempData["Active"] = TempDataInfo.Job;

            PersonelGorevlendirListDto PersonelGorevlendirModel = new PersonelGorevlendirListDto();
            PersonelGorevlendirModel.User = _mapper.Map<UserListDto>(_userManager.Users.FirstOrDefault
                (M => M.Id == userId));
            var jobid = Convert.ToInt32(TempData["jobId"]);
            PersonelGorevlendirModel.Job = _mapper.Map<JobListDto>
                (_jobService.getirDepIdile(Convert.ToInt32(TempData["jobId"])));

            return View(PersonelGorevlendirModel);
        }


        public IActionResult IsciElaveEt(int jobId)
        {
            TempData["Active"] = TempDataInfo.Job;
            TempData["jobId"] = jobId;
            return View(_mapper.Map<List<UserListDto>>(_appUser.Issizler()));
        }
    }
}
