using AutoMapper;
using DevProject.Business.Abstract;
using DevProject.DTO.DTOs.JobDtos;
using DevProject.Entities.Concrete;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DevProject.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class AdminController : Controller
    {
        private readonly IJobService _jobService;
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public AdminController(IJobService jobService, IDepartmentService departmentService, IMapper mapper)
        {
            _jobService = jobService;
            _departmentService = departmentService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            TempData["Active"] = TempDataInfo.Job;
            return View(_mapper.Map<List<JobListDto>>(_jobService.List()));
        }



        public IActionResult Add()
        {
            TempData["Active"] = TempDataInfo.Job;
            var list = _departmentService.List();
            ViewBag.Departments = new SelectList(list, "DepartmentId", "DepartmentName");
            return View(new JobAddDto());
        }

        [HttpPost]
        public IActionResult Add(JobAddDto model)
        {
            TempData["Active"] = TempDataInfo.Job;
            if (ModelState.IsValid)
            {
                _jobService.Add(new Job
                {
                    Name = model.Name,
                    Description = model.Description,
                    DepartmentId = model.DepartmentId
                });
                return RedirectToAction("List");
            }
            var list = _departmentService.List();
            ViewBag.Departments = new SelectList(list, "DepartmentId", "DepartmentName");
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["Active"] = TempDataInfo.Job;
            var list = _departmentService.List();
            var job = _jobService.GetById(id);
            ViewBag.Departments = new SelectList(list, "DepartmentId", "DepartmentName", job.DepartmentId);
            return View(_mapper.Map<JobUpdateDto>(_jobService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(int id, JobUpdateDto model)
        {
            TempData["Active"] = TempDataInfo.Job;
            var job = _jobService.GetById(id);
            var list = _departmentService.List();
            if (ModelState.IsValid)
            {
                job.Name = model.Name;
                job.DepartmentId = model.DepartmentId;
                job.CreationDate = model.CreationDate;
                job.Description = model.Description;
                _jobService.Update(job);
                return RedirectToAction("List");
            }
            ViewBag.Departments = new SelectList(list, "DepartmentId", "DepartmentName", model.DepartmentId);
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            TempData["Active"] = TempDataInfo.Job;
            var job = _jobService.GetById(id);
            if (ModelState.IsValid)
            {
                _jobService.Delete(job);
                return RedirectToAction("List");
            }

            return null;
        }



    }
}
