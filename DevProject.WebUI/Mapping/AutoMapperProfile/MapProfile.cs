using AutoMapper;
using DevProject.DTO.DTOs.BildirimDtos;
using DevProject.DTO.DTOs.DepartmentDtos;
using DevProject.DTO.DTOs.JobDtos;
using DevProject.DTO.DTOs.ReportDtos;
using DevProject.DTO.DTOs.SignDtos;
using DevProject.DTO.DTOs.UserDtos;
using DevProject.Entities.Concrete;

namespace DevProject.WebUI.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region Department-DepartmentDtos
            CreateMap<DepartmentDetailsDto, Department>();
            CreateMap<Department, DepartmentDetailsDto>();
            CreateMap<DepartmentUpdateDto, Department>();
            CreateMap<Department, DepartmentUpdateDto>();
            CreateMap<DepartmentListDto, Department>();
            CreateMap<Department, DepartmentListDto>();
            CreateMap<DepartmetAddDto, Department>();
            CreateMap<Department, DepartmetAddDto>();
            #endregion

            #region Bildirim-BildirimDtos
            CreateMap<BildirimListDto, Bildirim>();
            CreateMap<Bildirim, BildirimListDto>();
            #endregion

            #region Job-JobDtos
            CreateMap<JobAddDto, Job>();
            CreateMap<Job, JobAddDto>();
            CreateMap<JobUpdateDto, Job>();
            CreateMap<Job, JobUpdateDto>();
            CreateMap<JobDetailsDto, Job>();
            CreateMap<Job, JobDetailsDto>();
            CreateMap<JobListDto, Job>();
            CreateMap<Job, JobListDto>();
            #endregion

            #region Report-ReportDtos
            CreateMap<ReportUpdateDto, Report>();
            CreateMap<Report, ReportUpdateDto>();
            CreateMap<ReportAddDto, Report>();
            CreateMap<Report, ReportAddDto>();
            #endregion

            #region AppUser-SignDtos
            CreateMap<SignInDto, AppUser>();
            CreateMap<AppUser, SignInDto>();
            CreateMap<SignUpDto, AppUser>();
            CreateMap<AppUser, SignUpDto>();
            #endregion

            #region AppUser-UserDtos
            CreateMap<AddUserDto, AppUser>();
            CreateMap<AppUser, AddUserDto>();
            CreateMap<UserDetailsDto, AppUser>();
            CreateMap<AppUser, UserDetailsDto>();
            CreateMap<UserListDto, AppUser>();
            CreateMap<AppUser, UserListDto>();
            #endregion
        }
    }
}
