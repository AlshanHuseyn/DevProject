using AutoMapper;
using DevProject.Business.Abstract;
using DevProject.DTO.DTOs.DepartmentDtos;
using DevProject.Entities.Concrete;
using DevProject.WebUI.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevProject.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class DepartmentController : Controller
    {
        private IDepartmentService _departmentService;
        private IJobService _jobService;
        private IAppUserService _appUser;
        private IMapper _mapper;

        public DepartmentController(IDepartmentService departmentService, IJobService jobService, IAppUserService appUser, IMapper mapper)
        {
            _departmentService = departmentService;
            _jobService = jobService;
            _appUser = appUser;
            _mapper = mapper;
        }

        public IActionResult List()
        {
            TempData["Active"] = TempDataInfo.Department;
            return View(_mapper.Map<List<DepartmentListDto>>(_departmentService.List()));
        }

        public IActionResult Add()
        {
            TempData["Active"] = TempDataInfo.Department;
            return View(new DepartmetAddDto());
        }


        [HttpPost]
        public IActionResult Add(DepartmetAddDto model)
        {
            TempData["Active"] = TempDataInfo.Department;
            if (ModelState.IsValid)
            {
                _departmentService.Add(new Department()
                {
                    DepartmentName = model.DepartmentName
                });
                return RedirectToAction("List");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["Active"] = TempDataInfo.Department;
            return View(_mapper.Map<DepartmentUpdateDto>(_departmentService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(DepartmentUpdateDto depModel)
        {
            TempData["Active"] = TempDataInfo.Department;
            if (ModelState.IsValid)
            {
                _departmentService.Update(new Department
                {
                    DepartmentId = depModel.Id,
                    DepartmentName = depModel.DepartmentName
                });
                return RedirectToAction("List");
            }
            return View(depModel);
        }

        public IActionResult Details(int id)
        {
            TempData["Active"] = TempDataInfo.Department;
            ViewBag.Jobs = _jobService.GetByDepId(id);
            ViewBag.Users = _appUser.GetDepListById(id);
            return View(_mapper.Map<DepartmentDetailsDto>(_departmentService.GetById(id)));
        }

        public IActionResult Delete(int id)
        {
            TempData["Active"] = TempDataInfo.Department;
            var dep = _departmentService.GetById(id);
            _departmentService.Delete(dep);
            return RedirectToAction("List");
        }
    }
}
